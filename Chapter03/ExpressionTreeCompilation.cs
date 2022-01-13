using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Chapter03
{
    [Description("Listing 3.14")]
    class ExpressionTreeCompilation
    {        
        static void Main()
        {
            Expression<Func<int, int, int>> adder = (x, y) => x + y;
            Func<int, int, int> executableAdder = adder.Compile();
            Console.WriteLine(executableAdder(2, 3));
        }
    }
}
