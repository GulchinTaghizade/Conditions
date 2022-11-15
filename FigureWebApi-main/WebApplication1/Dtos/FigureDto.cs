using WebApplication1.Figures;

namespace WebApplication1.Dtos
{
    public class FigureDto
    {
        public int Id { get; set; }
        public List<Point> Points { get; set; }
        public Point Center { get; set; } = null;
        public FigureTypes FigureType { get; set; }
    }
}
