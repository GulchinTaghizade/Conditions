using System.Collections.Generic;
using System.IO;
using FigureApp;


List<Figure> figlist = new List<Figure>();
Square sq1 = new Square(new List<Point>());
figlist.Add(sq1);
sq1.Side = 5;





Console.WriteLine("Please select one of the following number:");
Console.WriteLine("1) show all figures\n2) create a figure\n3) move figure\n4) rotate figure\n5) scale figure\n6)save to file\n0) exit");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1)
{
    foreach (var figure in figlist)
    {
        figure.FindArea();
        figure.FindPerimeter();
        figure.FindCenter();
        Console.WriteLine(figure.ToString());
    }
}
else if (choice==2)
{
    Console.WriteLine("Please select one of the following figure:\n1)Square\n2)Triangle\n3)Rectangle\n4)Cicrle");
    int ChoiceOfFig = Convert.ToInt32(Console.ReadLine());
    switch (ChoiceOfFig)
    {
        case 1:
            Square square = new Square(new List<Point>());
            Console.WriteLine("Insert the length of square's side:");
            square.Side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square created");
            figlist.Add(square);
            break;

        case 2:
            Triangle triangle = new Triangle(new List<Point>());
            Console.WriteLine("Insert the length of first side:");
            triangle.SideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the length of second side:");
            triangle.SideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the length of third side:");
            triangle.SideC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Triangle created");
            figlist.Add(triangle);
            break;

        case 3:
            Rectangle rectangle = new Rectangle(new List<Point>());
            Console.WriteLine("Insert the length of first side:");
            rectangle.SideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the length of second side:");
            rectangle.SideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rectangle created");
            figlist.Add(rectangle);
            break;
        case 4:
            Circle circle = new Circle(new List<Point>());
            Console.WriteLine("Insert the length of the radius:");
            circle.Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Circle created");
            figlist.Add(circle);
            break;
        default:
            Console.WriteLine("Please try again!!!");
            break;
    }
}
else if (choice==3)
{

}
else if (choice==6)
{
    string path = @"/Users/gulchinnl/Desktop/figure.txt";
    using var sw = new StreamWriter(path);
    foreach (var figure in figlist)
    {
        sw.WriteAsync(figure.ToString());
    }
}






