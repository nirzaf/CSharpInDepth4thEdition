using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter03
{
    [Description("Listing 3.11")]
    class CapturingMultipleScopesImpl
    {
        private class OuterContext
        {
            public int outerCounter;
        }

        private class InnerContext
        {
            public OuterContext outerContext;
            public int innerCounter;

            public void Method()
            {
                Console.WriteLine(
                    "Outer: {0}; Inner: {1}",
                    outerContext.outerCounter, innerCounter);
                outerContext.outerCounter++;
                innerCounter++;
            }
        }

        static List<Action> CreateCountingActions()
        {
            List<Action> actions = new List<Action>();
            OuterContext outerContext = new OuterContext();
            outerContext.outerCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                InnerContext innerContext = new InnerContext();
                innerContext.outerContext = outerContext;
                innerContext.innerCounter = 0;
                Action action = innerContext.Method;
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
