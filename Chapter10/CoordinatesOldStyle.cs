using System;
using System.ComponentModel;

namespace Chapter10
{
    [Description("Listing 10.1")]
    class CoordinatesOldStyle
    {
        static void Main()
        {
            Console.WriteLine(PolarToCartesian(60, 20));
        }

        static Point PolarToCartesian(double degrees, double magnitude)
        {
            double radians = degrees * Math.PI / 180;
            return new Point(
                Math.Cos(radians) * magnitude,
                Math.Sin(radians) * magnitude);
        }
    }
}
