using System;
using System.Reflection;

namespace Chapter10
{
    class ExceptionThrowingFilter
    {
        // This listing isn't described in the book, but demonstrates the behaviour when
        // an exception filter *itself* throws an exception.
        // The ThrowingMethod method at the bottom throws an exception from its try
        // block, but the filter uses e.Message[100], which will throw another exception
        // (as the message isn't that long).
        // 
        // At the time of this writing, the behavior varies based on how the method is being called:
        // - When being called directly or dynamically, the filter that throws the exception is ignored
        // - When being called using reflection, the original exception is the one that's caught,
        //   but the exception thrown by the filter is the one that a higher level filter ends up seeing.
        //
        // This is a bug in the runtime, which is likely to be fixed in the future.

        static void Main()
        {
            var instance = new ExceptionThrowingFilter();
            Console.WriteLine("Calling directly");
            try
            {
                instance.MethodCaller();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caught: {e.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Calling with reflection");
            try
            {
                typeof(ExceptionThrowingFilter).GetMethod(nameof(MethodCaller)).Invoke(instance, null);
            }
            catch (TargetInvocationException e)
            {
                Console.WriteLine($"Caught: {e.InnerException.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Calling dynamically");
            try
            {
                dynamic d = instance;
                d.MethodCaller();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caught: {e.Message}");
            }
        }

        public void MethodCaller()
        {
            try
            {
                ThrowingMethod();
            }
            catch (Exception e) when (Log(e))
            {
            }
        }

        static bool Log(Exception e)
        {
            Console.WriteLine($"Filtered: {e.Message}");
            return false;
        }

        public static void ThrowingMethod()
        {
            try
            {
                throw new Exception("Short message");
            }
            catch (Exception e) when (e.Message[100] == 'x')
            {
            }
        }
    }
}
