using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            ShapeType = "Rectangle";
            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;
        public override double Perimeter => 2 * (Width + Height);

        public void PrintInfo()
        {
            Console.WriteLine($"Shape: {ShapeType}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
