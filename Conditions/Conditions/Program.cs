using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.User gives 2 numbers a and b. If a> b then output a + b, if a = b then output a* b, if a < b then a-b.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine($"a+b={a + b}");
            //}
            //else if (a == b)
            //{
            //    Console.WriteLine($"a*b={a * b}");
            //}
            //else
            //{
            //    Console.WriteLine($"a-b={a - b}");
            //}
            #endregion

            #region Task2
            //2.User gives 2 numbers x and y. Find out coordinate quarter of point with location(x, y).
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //if (x>0 && y>0)
            //{
            //    Console.WriteLine($"{(x, y)} is located in 1st quadrant");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine($"{(x, y)} is located in 4th quadrant");
            //}
            // else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine($"{(x, y)} is located in 2nd quadrant");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine($"{(x, y)} is located in 3rd quadrant");
            //}
            #endregion

            #region Task3
            //3.User gives 3 numbers a, b, c. Output them in the ascending order.
            //    Console.WriteLine("Please enter the number a:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the number b:");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the number c:");
            //    int c = Convert.ToInt32(Console.ReadLine());
            //    if (a<b && b<c )
            //    {
            //        Console.WriteLine($"{a} {b} {c}");
            //    }
            //    else if (a>b && b>c)
            //    {
            //        Console.WriteLine($" {c} {b} {a}");
            //    }
            //    else if (a>b && c>a )
            //    {
            //        Console.WriteLine($"{b} {a} {c}");
            //    }
            //    else if (a<b && a> c)
            //    {
            //        Console.WriteLine($"{c} {a} {b}");
            //    }
            //    else if (a>b && b<c && a>c)
            //    {
            //        Console.WriteLine($"{b} {c} {a}");
            //    }
            //    else if (a<b && b>c && a<c)
            //    {
            //        Console.WriteLine($"{a} {c} {b}");
            //    }
            //    else if(a==b && b==c)
            //    {
            //        Console.WriteLine("Numbers are equal"); 
            //    }
            //}


            #endregion

            #region Task 4
            //4.User gives 3 numbers a, b, c. Find out solution of quadratic equation ax ^ 2 + bx + c = 0.
            //Console.WriteLine("Please enter the number a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the number b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the number c:");
            //int c = Convert.ToInt32(Console.ReadLine());
            //double disc = (b * b) - (4 * a * c);
            //if (disc >= 0)
            //{
            //    double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
            //    Console.WriteLine($"x1: {x1} \nx2: {x2}");
            //}
            //else
            //{
            //    Console.WriteLine("There is no any real root of equation");
            //}

            #endregion
                
            #region Task 6
            //6.User gives 3 numbers x, y, r. Find out if point with location (x,y) is inside the circle with radius r?
            // Console.WriteLine("Please enter x:");
            //int x=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter y:");
            //int y=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter r:");
            //int r=Convert.ToInt32(Console.ReadLine());
            //if(((x*x+y*y)<r*r)){
            //Console.WriteLine($"({x},{y}) is located inside of the circle with radius {r}");
            //}
            //else if(((x*x+y*y)==r*r)){
            //Console.WriteLine($"({x},{y}) is located on  the circle with radius {r}");
            //}
            //else{
            //Console.WriteLine($"({x},{y}) is located outside of the circle with radius {r}");
            // }

            #endregion
        }
    }
}
