using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.8")]
    class AwaitInsideLoopDecompiled
    {
        [AsyncStateMachine(typeof(AwaitInLoopStateMachine))]
        [DebuggerStepThrough]
        private static unsafe Task PrintAndWaitWithSimpleLoop(TimeSpan delay)
        {
            var machine = new AwaitInLoopStateMachine
            {
                delay = delay,
                builder = AsyncTaskMethodBuilder.Create(),
                state = -1
            };
            machine.builder.Start(ref machine);
            return machine.builder.Task;
        }

        [CompilerGenerated]
        private struct AwaitInLoopStateMachine : IAsyncStateMachine
        {
            public int state;
            public AsyncTaskMethodBuilder builder;
            private TaskAwaiter awaiter;
            private int i;
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
                        goto AwaitContinuation;
                }
            MethodStart:
                Console.WriteLine("Before loop");
                this.i = 0;
                goto ForLoopCondition;
            ForLoopBody:
                Console.WriteLine("Before await in loop");
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
                Console.WriteLine("After await in loop");
                this.i++;
            ForLoopCondition:
                if (this.i < 3)
                {
                    goto ForLoopBody;
                }
                Console.WriteLine("After loop delay");
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

        static async Task AwaitInLoop(TimeSpan delay)
        {
            Console.WriteLine("Before loop");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Before await in loop");
                await Task.Delay(delay);
                Console.WriteLine("After await in loop");
            }
            Console.WriteLine("After loop delay");
        }

        static void Main()
        {
            AwaitInLoop(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
