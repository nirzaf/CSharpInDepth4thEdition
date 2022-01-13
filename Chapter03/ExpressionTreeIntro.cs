using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Chapter03
{
    [Description("Listing 3.12")]
    class ExpressionTreeIntro
    {        
        static void Main()
        {
            Expression<Func<int, int, int>> adder = (x, y) => x + y;
            Console.WriteLine(adder);
        }
    }
}
