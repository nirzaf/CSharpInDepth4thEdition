using static System.Math;

namespace Chapter12
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public override double Area => Width * Height;

        public Rectangle(double width, double height) => (Width, Height) = (width, height);
    }

    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public override double Area
        {
            get
            {
                // Heron's formula... see https://en.wikipedia.org/wiki/Heron%27s_formula
                double s = (SideA + SideB + SideC) / 2;
                return Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public Triangle(double sideA, double sideB, double sideC) =>
            (SideA, SideB, SideC) = (sideA, sideB, sideC);
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public override double Area => PI * Radius * Radius;

        public Circle(double radius) => Radius = radius;
    }
}
