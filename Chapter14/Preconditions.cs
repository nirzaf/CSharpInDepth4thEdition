using System;

namespace Chapter14
{
    static class Preconditions
    {
        internal static T CheckNotNull<T>(T value, string paramName) where T : class
            => value ?? throw new ArgumentNullException(paramName);
    }
}
