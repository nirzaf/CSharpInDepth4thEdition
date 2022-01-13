using System;

namespace Chapter09Net40
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            FormattableString formattable = $"value={value}";
            Console.WriteLine(formattable.Format);
            Console.WriteLine(formattable.GetArgument(0));
        }
    }
}
