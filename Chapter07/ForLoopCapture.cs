using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter07
{
    [Description("Listing 7.2")]
    class ForLoopCapture
    {
        static void Main()
        {
            List<string> names = new List<string> { "x", "y", "z" };
            var actions = new List<Action>();
            for (int i = 0; i < names.Count; i++)
            {
                actions.Add(() => Console.WriteLine(names[i]));
            }
            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}
