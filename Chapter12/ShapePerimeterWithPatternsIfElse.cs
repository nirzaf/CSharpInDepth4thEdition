using System;
using System.ComponentModel;
using static System.Math;

namespace Chapter12
{
    [Description("Listing 12.13")]
    class ShapePerimeterWithPatternsIfElse
    {
        static void Main()
        {
            Rectangle r = new Rectangle(10, 5);
            Triangle t = new Triangle(3, 4, 5);
            Circle c = new Circle(10);
            Console.WriteLine($"Perimeter of rectangle: {Perimeter(r)}");
            Console.WriteLine($"Perimeter of triangle: {Perimeter(t)}");
            Console.WriteLine($"Perimeter of circle: {Perimeter(c)}");
        }

        static double Perimeter(Shape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape));
            if (shape is Rectangle rect)
                return 2 * (rect.Height + rect.Width);
            if (shape is Circle circle)
                return 2 * PI * circle.Radius;
            if (shape is Triangle triangle)
                return triangle.SideA + triangle.SideB + triangle.SideC;
            throw new ArgumentException($"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
        }
    }
}
