using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Figures;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<FigureController> _logger;
        List<Figure> figlist;
        public FigureController(ILogger<FigureController> logger)
        {
            _logger = logger;
            figlist = MenuActions.ReadFromFile();
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}




        [HttpGet]
        public IEnumerable<FigureVM> Get()
        {
            return figlist.Select(f=> new FigureVM
            {
                Area = f.Area,
                Perimeter = f.Perimeter,
                Id=f.Id

            }).ToList();
        }


        [HttpGet(("{id}"))]
        public IActionResult GetByID(int id)
        {
            var figure = figlist.FirstOrDefault(s => s.Id == id);
            if (figure == null) return NotFound();
            return Ok(figure);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var figure = figlist.FirstOrDefault(s => s.Id == id);
            if (figure == null) return NotFound();
            figlist.Remove(figure);
            MenuActions.SaveToFile("figure.json",figlist);
            return Ok(figure);
        }

        [HttpPost]
        public IActionResult Post(FigureDto figure)
        {
            Figure newFigure;
            switch (figure.FigureType)
            {
                case FigureTypes.Triangle:
                    newFigure = new Triangle(figure.Points);
                    break;
                case FigureTypes.Circle:
                    newFigure = new Circle(figure.Points);
                    newFigure.Center=figure.Center;
                    break;
                case FigureTypes.Square:
                    newFigure = new Square(figure.Points);
                    break;
                case FigureTypes.Rectangle:
                    newFigure = new Rectangle(figure.Points);
                    break;
                default:
                    return BadRequest("Unknown figure type");
                    break;
            }
            newFigure.Id = figure.Id;

            figlist.Add(newFigure);
            MenuActions.SaveToFile("figure.json", figlist);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            if (id == null || id == 0)
                return BadRequest();

            var figure = figlist.Find(s => s.Id == id);
            if (figure == null)
                return NotFound();
            MenuActions.ChangeFigure(figlist);
            return Ok();
        }

    }
}