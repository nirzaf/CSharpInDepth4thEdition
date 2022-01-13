using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter13
{
    /// <summary>
    /// Meaningless, but pretty large as structs go...
    /// </summary>
    public readonly struct LargeStruct
    {
        public long X { get; }
        public long Y { get; }
        public long Z { get; }
        public double Weight { get; }
        public double Score { get; }

        public LargeStruct(long x, long y, long z, double weight, double score) =>
            (X, Y, Z, Weight, Score) = (x, y, z, weight, score);
    }
}
