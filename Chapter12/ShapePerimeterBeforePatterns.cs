using System;
using System.ComponentModel;
using static System.Math;

namespace Chapter12
{
    [Description("Listing 12.10")]
    class ShapePerimeterBeforePatterns
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
            Rectangle rect = shape as Rectangle;
            if (rect != null)
                return 2 * (rect.Height + rect.Width);
            Circle circle = shape as Circle;
            if (circle != null)
                return 2 * PI * circle.Radius;
            Triangle triangle = shape as Triangle;
            if (triangle != null)
                return triangle.SideA + triangle.SideB + triangle.SideC;
            throw new ArgumentException($"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
        }
    }
}
