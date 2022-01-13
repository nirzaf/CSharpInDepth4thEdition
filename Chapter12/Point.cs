using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.4 and 10.7")]
    public sealed class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) => (X, Y) = (x, y);

        public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
    }

    [Description("Listing 12.7")]
    class PointDeconstruction
    {
        static void Main()
        {
            var point = new Point(1.5, 20);
            var (x, y) = point;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
}
