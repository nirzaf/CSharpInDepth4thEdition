using System;
using System.ComponentModel;
using System.Linq.Expressions;
using static System.Linq.Queryable;

namespace Chapter10
{
    [Description("Listing 10.3")]
    class UsingStaticExtensionMethods1
    {
        static void Main()
        {
            var query = new[] { "a", "bc", "d" }.AsQueryable();

            Expression<Func<string, bool>> expr = x => x.Length > 1;
            Func<string, bool> del = x => x.Length > 1;

            var valid = query.Where(expr);
            // var invalid = query.Where(del);
        }
    }
}
