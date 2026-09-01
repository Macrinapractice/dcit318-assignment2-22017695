using System;

namespace AbstractClasses
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method to calculate area
        public abstract double GetArea();
    }

    // Circle implements GetArea
    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle implements GetArea
    class Rectangle : Shape
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5); // sample radius
            var rectangle = new Rectangle(10, 5); // sample length and width

            Console.WriteLine($"Circle Area: {circle.GetArea():0.##}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():0.##}");
        }
    }
}
