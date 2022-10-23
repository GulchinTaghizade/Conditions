using System;
namespace FigureApp
{
    public abstract class Figure
    {
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }
        public List<Point> Points { get; protected set; }
        public Point Center { get; protected set; }

        public Figure(List<Point> points)
        {
            this.Points = points;
            this.FindArea();
            this.FindPerimeter();
            this.FindCenter();
        }

        public abstract void FindArea();
        public abstract void FindPerimeter();
        public abstract void FindCenter();
        public abstract void MoveFigure(double x, double y);
        public abstract void RotateFigure(double degree);
        public abstract void ScaleFigure(double scale);

       
    }
}

