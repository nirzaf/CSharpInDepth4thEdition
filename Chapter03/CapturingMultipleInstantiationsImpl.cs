using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 3.9")]
    class CapturingMultipleInstantiationsImpl
    {
        private class LambdaContext
        {
            public string text;

            public void Method()
            {
                Console.WriteLine(text);
            }
        }

        static List<Action> CreateActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                LambdaContext context = new LambdaContext();
                context.text = string.Format("message {0}", i);
                actions.Add(context.Method);
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
