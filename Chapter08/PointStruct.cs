using System.ComponentModel;

namespace Chapter08
{
    [Description("Listing 8.12")]
    public struct PointStruct
    {
        public double X { get; }
        public double Y { get; }

        public PointStruct(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

}
