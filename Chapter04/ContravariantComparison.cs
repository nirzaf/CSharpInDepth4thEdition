using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.21")]
    class ContravariantComparison
    {
        // Note: these classes use some C# 6 and 7 features for brevity.
        // Those features are not directly related to generic variance.
        abstract class Shape
        {
            public abstract double Area { get; }
        }

        class Circle : Shape
        {
            public double Radius { get; }
            public override double Area => Radius * Radius;

            public Circle(double radius) => Radius = radius;
        }

        // Not actually used, but you could sort a List<Rectangle> in the same way.
        class Rectangle : Shape
        {
            public double Width { get; }
            public double Height { get; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double Area => Width * Height;
        }

        class AreaComparer : IComparer<Shape>
        {
            public int Compare(Shape x, Shape y) => x.Area.CompareTo(y.Area);
        }

        static void Main()
        {
            List<Circle> circles = new List<Circle>
            {
                new Circle(5.3),
                new Circle(2),
                new Circle(10.5)
            };
            circles.Sort(new AreaComparer());
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle.Radius);
            }
        }
    }
}
