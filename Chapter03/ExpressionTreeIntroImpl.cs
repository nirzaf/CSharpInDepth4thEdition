using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Chapter03
{
    [Description("Listing 3.13")]
    class ExpressionTreeIntroImpl
    {        
        static void Main()
        {
            ParameterExpression xParameter = Expression.Parameter(typeof(int), "x");
            ParameterExpression yParameter = Expression.Parameter(typeof(int), "y");
            Expression body = Expression.Add(xParameter, yParameter);
            ParameterExpression[] parameters = new[] { xParameter, yParameter };

            Expression<Func<int, int, int>> adder =
                Expression.Lambda<Func<int, int, int>>(body, parameters);
            Console.WriteLine(adder);
        }
    }
}
