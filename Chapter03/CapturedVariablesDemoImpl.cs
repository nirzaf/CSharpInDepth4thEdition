#pragma warning disable CS0219 // Variable is assigned but its value is never used
using System;
using System.ComponentModel;

namespace Chapter02
{
    // Note that the name CatpuredVariablesDemoImpl is used instead of CapturedVariablesImpl
    [Description("Listing 3.7")]
    class CapturedVariablesDemoImpl
    {
        private string instanceField = "instance field";

        private class LambdaContext
        {
            public CapturedVariablesDemoImpl originalThis;
            public string methodParameter;
            public string methodLocal;

            public void Method(string lambdaParameter)
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field: {0}", originalThis.instanceField);
                Console.WriteLine("Method parameter: {0}", methodParameter);
                Console.WriteLine("Method local: {0}", methodLocal);
                Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
                Console.WriteLine("Lambda local: {0}", lambdaLocal);
            }
        }

        public Action<string> CreateAction(string methodParameter)
        {
            LambdaContext context = new LambdaContext();
            context.originalThis = this;
            context.methodParameter = methodParameter;
            context.methodLocal = "method local";
            string uncaptured = "uncaptured local";

            Action<string> action = context.Method;
            context.methodLocal = "modified method local";
            return action;
        }

        static void Main()
        {
            var demo = new CapturedVariablesDemoImpl();
            Action<string> action = demo.CreateAction("method argument");
            action("lambda argument");
        }
    }
}
