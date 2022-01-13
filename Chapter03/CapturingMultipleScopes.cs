using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter03
{
    [Description("Listing 3.10")]
    class CapturingMultipleScopes
    {
        static List<Action> CreateCountingActions()
        {
            List<Action> actions = new List<Action>();
            int outerCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                int innerCounter = 0;
                Action action = () =>
                {
                    Console.WriteLine(
                        "Outer: {0}; Inner: {1}",
                        outerCounter, innerCounter);
                    outerCounter++;
                    innerCounter++;
                };
                actions.Add(action);
            }
            return actions;
        }

        static void Main()
        {
            List<Action> actions = CreateCountingActions();
            actions[0]();
            actions[0]();
            actions[1]();
            actions[1]();
        }
    }
}
