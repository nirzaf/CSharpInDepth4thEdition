using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.15")]
    class GenericTypeCase
    {
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Circle(15.2),
                new Rectangle(20.3, 10.2),
                new Triangle(12.1, 15.9, 13.8)
            };

            DisplayShapes(shapes);
            DisplayShapes(new List<Circle> { new Circle(10.2), new Circle(15.2) });
        }

        static void DisplayShapes<T>(List<T> shapes) where T : Shape
        {
            foreach (T shape in shapes)
            {
                switch (shape)
                {
                    case Circle c:
                        Console.WriteLine($"Circle radius {c.Radius}");
                        break;
                    case Rectangle r:
                        Console.WriteLine($"Rectangle {r.Width} x {r.Height}");
                        break;
                    case Triangle t:
                        Console.WriteLine($"Triangle sides {t.SideA}, {t.SideB}, {t.SideC}");
                        break;
                }
            }
        }
    }
}
