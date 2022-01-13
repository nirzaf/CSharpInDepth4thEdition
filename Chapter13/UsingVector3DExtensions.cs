using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.19")]
    class UsingVector3DExtensions
    {
        static void Main()
        {
            var vector = new Vector3D(1.5, 2.0, 3.0);
            var offset = new Vector3D(5.0, 2.5, -1.0);

            vector.OffsetBy(offset);

            Console.WriteLine($"({vector.X}, {vector.Y}, {vector.Z})");
            Console.WriteLine(vector.Magnitude());
        }
    }
}
