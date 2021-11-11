using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;

            rectangle.Height = a;
            rectangle.Width = b;
            area = rectangle.Area();
            Console.WriteLine("Area of rectangle is : {0:F}", area);
            perimeter = rectangle.Perimeter();
            Console.WriteLine("Perimeter of rectangle is : {0:F}", perimeter);

            Console.WriteLine("--------------------------------------------");

            circle.Radius = c;
            area = circle.Area();
            Console.WriteLine("Area of circle is : {0:F}", area);
            perimeter = circle.Perimeter();
            Console.WriteLine("Perimeter of circle is : {0:F}", perimeter);

            Console.WriteLine("----------------------------------------------");
            triangle.SideA = a;
            triangle.SideB = b;
            triangle.SideC = c;
            area = triangle.Area();
            Console.WriteLine("Area of triangle is : {0:F}", area);
            perimeter = triangle.Perimeter();
            Console.WriteLine("Perimeter of triangle is : {0:F}", perimeter);
            Console.ReadLine();

        }
    }
}
