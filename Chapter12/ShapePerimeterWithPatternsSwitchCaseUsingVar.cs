using System;
using System.ComponentModel;
using static System.Math;

namespace Chapter12
{
    [Description("Listing 12.16")]
    class ShapePerimeterWithPatternsSwitchCaseUsingVar
    {
        static readonly Random random = new Random();

        static void Main()
        {
            Rectangle r = new Rectangle(10, 5);
            Triangle t = new Triangle(3, 4, 5);
            Circle c = new Circle(10);
            Console.WriteLine($"Perimeter of rectangle: {Perimeter(r)}");
            Console.WriteLine($"Perimeter of triangle: {Perimeter(t)}");
            Console.WriteLine($"Perimeter of circle: {Perimeter(c)}");            
        }

        static Shape CreateRandomShape()
        {
            switch (random.Next(3))
            {
                case 0: return new Rectangle(random.Next(10), random.Next(20));
                case 1: return new Triangle(random.Next(10), random.Next(10), random.Next(10));
                case 2: return new Circle(random.NextDouble() * 15);
                default: throw new InvalidOperationException("Random violated its contract...");
            }
        }

        static double Perimeter(Shape shape)
        {
            switch (shape ?? CreateRandomShape())
            {
                case Rectangle rect:
                    return 2 * (rect.Height + rect.Width);
                case Circle circle:
                    return 2 * PI * circle.Radius;
                case Triangle triangle:
                    return triangle.SideA + triangle.SideB + triangle.SideC;
                case var actualShape:
                    throw new InvalidOperationException($"Shape type {actualShape.GetType()} perimeter unknown");
            }
        }
    }
}
