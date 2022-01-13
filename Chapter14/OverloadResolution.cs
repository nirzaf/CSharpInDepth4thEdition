using System;

namespace Chapter14
{
    class OverloadResolution
    {
        static void Method1<T>(object x) where T : struct =>
            Console.WriteLine($"{typeof(T)} is a struct");

        static void Method1<T>(string x) where T : class =>
            Console.WriteLine($"{typeof(T)} is a reference type");

        static void Method2(object x) =>
            Console.WriteLine("Static method");

        void Method2(string x) =>
            Console.WriteLine("Instance method");

        void Method3(object x) =>
            Console.WriteLine("Instance method");

        static void Method3(string x) =>
            Console.WriteLine("Static method");

        static void Main()
        {
            // Overload with string parameter is better, but int violatesd the "where T : struct" constraint
            Method1<int>("text");

            // Overload with string parameter is better, but we can't call an instance method from a static
            // context without providing a reference to value it on.
            Method2("text");

            // Overload with string parameter is better, but we can't call a static method on a reference.
            var instance = new OverloadResolution();
            instance.Method3("text");
        }
    }
}
