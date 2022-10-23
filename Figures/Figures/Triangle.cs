using System;
namespace FigureApp
{
    public class Triangle:Figure
    {
        public double SideA;
        public double SideB;
        public double SideC;
        public Triangle(List<Point> points):base(points)
        {
        }

        public override void FindArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            this.Area= Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override void FindCenter()
        {
        }

        public override void FindPerimeter()
        {
            this.Perimeter= SideA + SideB + SideC;
        }

        public override void MoveFigure(double x, double y)
        {
            this.Center.CoordinateX = Center.CoordinateX + x;
            this.Center.CoordinateY = Center.CoordinateX + y;
        }

        public override void RotateFigure(double degree)
        {
            foreach (var p in Points)
            {
                p.CoordinateX = p.CoordinateX * Math.Cos(degree) - p.CoordinateY * Math.Sin(degree);
                p.CoordinateY = p.CoordinateY * Math.Cos(degree) + p.CoordinateX * Math.Sin(degree);
            }
        }

        public override void ScaleFigure(double scale)
        {
            foreach (var p in Points)
            {
                p.CoordinateX = Center.CoordinateX - scale * (Center.CoordinateX - p.CoordinateX);
                p.CoordinateY = Center.CoordinateY - scale * (Center.CoordinateY - p.CoordinateY);
            }
            this.FindPerimeter();
            this.FindArea();
        }
        public override string ToString()
        {
            return $"{nameof(Triangle)}\nArea:{Area}\nPerimeter:{Perimeter}";
        }
    }
}

