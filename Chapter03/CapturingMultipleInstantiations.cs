using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 3.8")]
    class CapturingMultipleInstantiations
    {
        static List<Action> CreateActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                string text = string.Format("message {0}", i);
                actions.Add(() => Console.WriteLine(text));
            }
            return actions;
        }

        static void Main()
        {
            List<Action> actions = CreateActions();
            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}
