using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.14")]
    class SafeInParameters
    {
        public static double PublicMethod(LargeStruct first, LargeStruct second)
        {
            double firstResult = PrivateMethod(in first);
            double secondResult = PrivateMethod(in second);
            return firstResult + secondResult;
        }

        private static double PrivateMethod(in LargeStruct input)
        {
            double scale = GetScale(in input);
            return (input.X + input.Y + input.Z) * scale;
        }

        private static double GetScale(in LargeStruct input) =>
            input.Weight * input.Score;

        static void Main()
        {
            LargeStruct first = new LargeStruct(1L, 2L, 3L, 4.1, 5.2);
            LargeStruct second = new LargeStruct(6L, 7L, 8L, 9.3, 10.4);

            double result = PublicMethod(first, second);
            Console.WriteLine(result);
        }
    }
}
