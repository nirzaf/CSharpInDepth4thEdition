using System;
using System.ComponentModel;
using static System.Math;

namespace Chapter15
{
    [Description("Listing 15.10")]
    class SwitchExpressionBodiedMember
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

        static double Perimeter(Shape shape) =>
            shape switch
            {
                null => throw new ArgumentNullException(nameof(shape)),
                Rectangle rect => 2 * (rect.Height + rect.Width),
                Circle circle => 2 * PI * circle.Radius,
                Triangle triangle => triangle.SideA + triangle.SideB + triangle.SideC,
                _ => throw new ArgumentException(
                    $"Shape type {shape.GetType()} perimeter unknown", nameof(shape))
            };
    }
}
