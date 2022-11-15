using System.Drawing;
using WebApplication1.Dtos;

namespace WebApplication1.ViewModels
{
    public class FigureVM 
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public List<Point> Points { get; set; }
        public Point Center { get; set; }
        public int Id { get; set; }
        public FigureTypes FigureType { get; set; }
    }
