using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.7")]
    class FibonacciWithGenerator
    {
        static void Main()
        {
            var fibonacci = GenerateSequence(
                (current: 0, next: 1),
                pair => (pair.next, pair.current + pair.next),
                pair => pair.current);
            foreach (var value in fibonacci.Take(10))
            {
                Console.WriteLine(value);
            }
        }

        static IEnumerable<TResult> GenerateSequence<TState, TResult>(
            TState seed,
            Func<TState, TState> generator,
            Func<TState, TResult> resultSelector)
        {
            var state = seed;
            while (true)
            {
                yield return resultSelector(state);
                state = generator(state);
            }
        }
    }
}
