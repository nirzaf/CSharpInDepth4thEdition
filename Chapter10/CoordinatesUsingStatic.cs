using System;
using System.ComponentModel;
using static System.Math;

namespace Chapter10
{
    [Description("Listing 10.2")]
    class CoordinatesUsingStatic
    {
        static void Main()
        {
            Console.WriteLine(PolarToCartesian(60, 20));
        }

        static Point PolarToCartesian(double degrees, double magnitude)
        {
            double radians = degrees * PI / 180;
            return new Point(
                Cos(radians) * magnitude,
                Sin(radians) * magnitude);
        }
    }
}
