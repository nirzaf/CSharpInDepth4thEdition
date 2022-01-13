using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter02
{
    class DecompilationExampleDecompiled
    {
        public static IEnumerable<int> GenerateIntegers(int count)
        {
            GeneratedClass ret = new GeneratedClass(-2);
            ret.count = count;
            return ret;
        }

        private class GeneratedClass : IEnumerable<int>, IEnumerator<int>
        {
            // Parameters
            public int count;

            // Indication of where to resume from
            private int state;

            // Value for the Current property
            private int current;

            private int initialThreadId;

            // Local variable
            private int i;

            public GeneratedClass(int state)
            {
                this.state = state;
                initialThreadId = Environment.CurrentManagedThreadId;
            }

            public bool MoveNext()
            {
                bool tryBlockCompletedNormally = false;
                try
                {
                    switch (state)
                    {
                        // Start of method
                        case 0:
                            state = -3;
                            goto methodStart;
                        // After first yield return
                        case 1:
                            state = -3;
                            goto afterFirstYieldReturn;
                        // After second yield return
                        case 2:
                            state = -3;
                            goto afterSecondYieldReturn;
                        // Either a misuse of the state machine, or it's
                        // already completed.
                        default:
                            tryBlockCompletedNormally = true;
                            return false;
                    }
                methodStart:
                    i = 0;
                loopCondition:
                    if (i < count)
                    {
                        goto loopBodyStart;
                    }
                    Finally1();
                    tryBlockCompletedNormally = true;
                    return false;
                loopBodyStart:
                    Console.WriteLine("Yielding {0}", i);
                    current = i;
                    state = 1;
                    tryBlockCompletedNormally = true;
                    return true;
                afterFirstYieldReturn:
                    int num2 = i * 2;
                    Console.WriteLine("Yielding {0}", num2);
                    current = num2;
                    state = 2;
                    tryBlockCompletedNormally = true;
                    return true;
                afterSecondYieldReturn:
                    i++;
                    goto loopCondition;
                }
                // In the IL, this is actually a "fault" block - it's like finally, but
                // is only executed if there's an exception. I'm using
                // tryBlockCompletedNormally to get roughly the same behavior.
                finally
                {
                    if (!tryBlockCompletedNormally)
                    {
                        Dispose();
                    }
                }
            }
            
            public IEnumerator<int> GetEnumerator()
            {
                GeneratedClass enumerator;
                if (state == -2 && initialThreadId == Environment.CurrentManagedThreadId)
                {
                    state = 0;
                    enumerator = this;
                }
                else
                {
                    enumerator = new GeneratedClass(0);
                    enumerator.count = count;
                }
                return enumerator;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public void Dispose()
            {
                int num = state;
                if (num == -3 || ((uint)(num - 1)) <= 1)
                {
                    try
                    {
                    }
                    finally
                    {
                        Finally1();
                    }
                }
            }

            public int Current
            {
                get { return current; }
            }

            object IEnumerator.Current
            {
                get { return current; }
            }

            private void Finally1()
            {
                state = -1;
                Console.WriteLine("In finally block");
            }
        }

        static void Main()
        {
            foreach (int value in GenerateIntegers(5))
            {
                Console.WriteLine(value);
            }
        }
    }
}
