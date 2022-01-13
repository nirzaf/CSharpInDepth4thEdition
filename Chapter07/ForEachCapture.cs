using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter07
{
    [Description("Listing 7.1")]
    class ForEachCapture
    {
        static void Main()
        {
            List<string> names = new List<string> { "x", "y", "z" };
            var actions = new List<Action>();
            foreach (string name in names)
            {
                actions.Add(() => Console.WriteLine(name));
            }
            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}
