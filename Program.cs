using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(5);
            //Rectangle rectangle = new Rectangle(4, 6);
            //Triangle triangle = new Triangle(3, 4, 5);

            //Console.WriteLine("Circle Information:");
            //circle.PrintInfo();

            //Console.WriteLine("\nRectangle Information:");
            //rectangle.PrintInfo();

            //Console.WriteLine("\nTriangle Information:");
            //triangle.PrintInfo();

            //Console.ReadKey();


            // for Circle
            Console.Write("Enter the radius of the circle: ");
            double circleRadius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(circleRadius);

            Console.WriteLine("\nCircle Information:");
            circle.PrintInfo();

            // for Rectangle
            Console.Write("\nEnter the width of the rectangle: ");
            double rectangleWidth = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double rectangleHeight = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight);

            Console.WriteLine("\nRectangle Information:");
            rectangle.PrintInfo();

            // for Triangle
            Console.Write("\nEnter the length of side A of the triangle: ");
            double triangleSideA = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side B of the triangle: ");
            double triangleSideB = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side C of the triangle: ");
            double triangleSideC = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(triangleSideA, triangleSideB, triangleSideC);

            Console.WriteLine("\nTriangle Information:");
            triangle.PrintInfo();

            Console.ReadKey();
        }
    }
}
