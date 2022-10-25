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
            SideA = Math.Sqrt((points[1].CoordinateX - points[0].CoordinateX) * (points[1].CoordinateX - points[0].CoordinateX) - 
                (points[1].CoordinateY - points[0].CoordinateY) * (points[1].CoordinateY - points[0].CoordinateY));
            SideB = Math.Sqrt((points[2].CoordinateX - points[1].CoordinateX) * (points[2].CoordinateX - points[1].CoordinateX) -
              (points[2].CoordinateY - points[1].CoordinateY) * (points[2].CoordinateY - points[1].CoordinateY));
            SideA = Math.Sqrt((points[2].CoordinateX - points[0].CoordinateX) * (points[2].CoordinateX - points[0].CoordinateX) -
              (points[1].CoordinateY - points[0].CoordinateY) * (points[1].CoordinateY - points[0].CoordinateY));

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
            foreach (var point in Points)
            {
                point.CoordinateX += x;
                point.CoordinateY += y;

            }
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

