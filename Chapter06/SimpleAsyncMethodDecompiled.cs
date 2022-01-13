using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.2")]
    class SimpleAsyncMethodDecompiled
    {
        [AsyncStateMachine(typeof(PrintAndWaitStateMachine))]
        [DebuggerStepThrough]
        private static unsafe Task PrintAndWait(TimeSpan delay)
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
                    TaskAwaiter awaiter1;
                    switch (num)
                    {
                        default:
                            goto MethodStart;
                        case 0:
                            goto FirstAwaitContinuation;
                        case 1:
                            goto SecondAwaitContinuation;
                    }
                MethodStart:
                    Console.WriteLine("Before first delay");
                    awaiter1 = Task.Delay(this.delay).GetAwaiter();
                    if (awaiter1.IsCompleted)
                    {
                        goto GetFirstAwaitResult;
                    }
                    this.state = num = 0;
                    this.awaiter = awaiter1;
                    this.builder.AwaitUnsafeOnCompleted(ref awaiter1, ref this);
                    return;
                FirstAwaitContinuation:
                    awaiter1 = this.awaiter;
                    this.awaiter = default(TaskAwaiter);
                    this.state = num = -1;
                GetFirstAwaitResult:
                    awaiter1.GetResult();
                    Console.WriteLine("Between delays");
                    TaskAwaiter awaiter2 = Task.Delay(this.delay).GetAwaiter();
                    if (awaiter2.IsCompleted)
                    {
                        goto GetSecondAwaitResult;
                    }
                    this.state = num = 1;
                    this.awaiter = awaiter2;
                    this.builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
                    return;
                SecondAwaitContinuation:
                    awaiter2 = this.awaiter;
                    this.awaiter = default(TaskAwaiter);
                    this.state = num = -1;
                GetSecondAwaitResult:
                    awaiter2.GetResult();
                    Console.WriteLine("After second delay");
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
            PrintAndWait(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
