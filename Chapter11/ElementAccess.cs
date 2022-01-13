using System;
using System.ComponentModel;

namespace Chapter11
{
    [Description("Listing 11.2")]
    class ElementAccess
    {
        static void Main()
        {
            var tuple = (x: 5, 10);
            Console.WriteLine(tuple.x);    
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2); 

            tuple.x = 100;                   
            Console.WriteLine(tuple.Item1); // Prints 100
        }
    }
}
