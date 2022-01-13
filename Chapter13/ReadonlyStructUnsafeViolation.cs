using System;

namespace Chapter13
{
    // Sample just to show how unsafe code can violate the readonly modifier.

    readonly struct EvilStruct
    {
        public int Value { get; }

        public EvilStruct(int value) => Value = value;

        public unsafe void Mutate(int newValue)
        {
            fixed (EvilStruct* me = &this)
            {
                *me = new EvilStruct(newValue);
            }
        }
    }

    class ReadonlyStructUnsafeViolation
    {
        private static readonly EvilStruct evil = new EvilStruct(10);

        static void Main()
        {
            Console.WriteLine(evil.Value);
            evil.Mutate(20);
            Console.WriteLine(evil.Value);
        }
    }
}
