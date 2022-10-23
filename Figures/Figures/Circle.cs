using System;
namespace FigureApp
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(List<Point> points) : base(points)
        {
            Radius = Math.Sqrt(((points[0].CoordinateX - points[1].CoordinateX) * (points[0].CoordinateX - points[1].CoordinateX)) +
                 ((points[0].CoordinateY - points[1].CoordinateY) * (points[0].CoordinateY - points[1].CoordinateY)));
        }

        public override void FindArea()
        {
            this.Area = Math.PI * Radius * Radius;
        }

        public override void FindPerimeter()
        {
            this.Perimeter = 2 * Math.PI * Radius;
        }

        public override void MoveFigure(double x, double y)
        {
            this.Center.CoordinateX = Center.CoordinateX + x;
            this.Center.CoordinateY = Center.CoordinateX + y;
        }

        public override void RotateFigure(double degree)
        {
        }

        public override void ScaleFigure(double scale)
        {
            Radius = Radius * scale;
            this.FindPerimeter();
            this.FindArea();
        }

        public override void FindCenter()
        {
            Center = Points[0];
        }
        public override string ToString()
        {
            return $"{nameof(Circle)}\nArea:{Area}\nPerimeter:{Perimeter}";
        }
    }
}

