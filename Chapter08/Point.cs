using System;
using System.ComponentModel;

namespace Chapter08
{
    [Description("Listing 8.15, 6.16")]
    public sealed class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);

        public static Point Add(Point left, Vector right) => left + right;

        public static Point operator +(Point left, Vector right) =>
            new Point(left.X + right.X, left.Y + right.Y);
    }
}
