using System;
using System.ComponentModel;
using static System.Math;

namespace Chapter15
{
    [Description("Listing 15.11")]
    class PropertyPatterns1
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

        static double Perimeter(Shape shape) => shape switch
        {
            null => throw new ArgumentNullException(nameof(shape)),
            Rectangle { Height: var h, Width: var w } => 2 * (h + w),
            Circle { Radius: var radius } => 2 * PI * radius,
            Triangle { SideA: var a, SideB: var b, SideC: var c } => a + b + c,
            _ => throw new ArgumentException(
                $"Shape type {shape.GetType()} perimeter unknown", nameof(shape))
        };
    }
}
