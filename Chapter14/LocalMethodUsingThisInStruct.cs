using System;

namespace Chapter14
{
    public struct SimpleValue
    {
        public int Value { get; }

        public SimpleValue(int value) => this.Value = value;

        public void PrintAndReplace(int newValue)
        {
            PrintAndReplaceImpl(ref this);

            void PrintAndReplaceImpl(ref SimpleValue _this)
            {
                // Using this instead of _this causes a compile-time error
                Console.WriteLine($"Old value: {_this.Value}");
                _this = new SimpleValue(newValue);
            }
        }
    }

    public class LocalMethodUsingThisInStruct
    {
        static void Main()
        {
            var simpleValue = new SimpleValue(10);
            Console.WriteLine(simpleValue.Value); // 10
            simpleValue.PrintAndReplace(20);      // Prints "Old value: 10"
            Console.WriteLine(simpleValue.Value); // 20
        }
    }
}
