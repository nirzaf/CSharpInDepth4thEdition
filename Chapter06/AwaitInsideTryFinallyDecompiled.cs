using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.10")]
    class AwaitInsideTryFinallyDecompiled
    {
        [AsyncStateMachine(typeof(PrintAndWaitStateMachine))]
        [DebuggerStepThrough]
        private static unsafe Task AwaitInTryFinally(TimeSpan delay)
        {
            var machine = new PrintAndWaitStateMachine
            {
                delay = delay,
                builder = AsyncTaskMethodBuilder.Create(),
                state = -1
            };
            machine.builder.Start(ref machine);
            return machine.builder.Task;
        }

        [CompilerGenerated]
        private struct PrintAndWaitStateMachine : IAsyncStateMachine
        {
            public int state;
            public AsyncTaskMethodBuilder builder;
            private TaskAwaiter awaiter;
            public TimeSpan delay;

            void IAsyncStateMachine.MoveNext()
            {
                int num = this.state;
                try
                {
                    switch (num)
                    {
                        default:
                            goto MethodStart;
                        case 0:
                            goto AwaitContinuationTrampoline;
                    }
                MethodStart:
                    Console.WriteLine("Before try");
                AwaitContinuationTrampoline:
                    try
                    {
                        switch (num)
                        {
                            default:
                                goto TryBlockStart;
                            case 0:
                                goto AwaitContinuation;
                        }
                    TryBlockStart:
                        Console.WriteLine("Before await");
                        TaskAwaiter awaiter = Task.Delay(this.delay).GetAwaiter();
                        if (awaiter.IsCompleted)
                        {
                            goto GetAwaitResult;
                        }
                        this.state = num = 0;
                        this.awaiter = awaiter;
                        this.builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
                        return;
                    AwaitContinuation:
                        awaiter = this.awaiter;
                        this.awaiter = default(TaskAwaiter);
                        this.state = num = -1;
                    GetAwaitResult:
                        awaiter.GetResult();
                        Console.WriteLine("After await");
                    }
                    finally
                    {
                        if (num < 0)
                        {
                            Console.WriteLine("In finally block");
                        }
                    }
                    Console.WriteLine("After finally block");
                }
                catch (Exception exception)
                {
                    this.state = -2;
                    this.builder.SetException(exception);
                    return;
                }
                this.state = -2;
                this.builder.SetResult();
            }

            [DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                this.builder.SetStateMachine(stateMachine);
            }
        }

        static void Main()
        {
            AwaitInTryFinally(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
