#pragma warning disable CS0219 // Variable is assigned but its value is never used
using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 3.6")]
    class CapturedVariablesDemo
    {
        private string instanceField = "instance field";

        public Action<string> CreateAction(string methodParameter)
        {
            string methodLocal = "method local";
            string uncaptured = "uncaptured local";

            Action<string> action = lambdaParameter =>
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field: {0}", instanceField);
                Console.WriteLine("Method parameter: {0}", methodParameter);
                Console.WriteLine("Method local: {0}", methodLocal);
                Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
                Console.WriteLine("Lambda local: {0}", lambdaLocal);
            };
            return action;
        }

        static void Main()
        {
            var demo = new CapturedVariablesDemo();
            Action<string> action = demo.CreateAction("method argument");
            action("lambda argument");
        }
    }
}
