using System;
using System.Threading.Tasks;

namespace Chapter05
{
    class ManuallyInducedCancellation
    {
        static void Main()
        {
            Task task = ThrowCancellationException();
            Console.WriteLine(task.Status);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        static async Task ThrowCancellationException()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            throw new OperationCanceledException();
        }
    }
}
