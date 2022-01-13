using NodaTime.Extensions;
using System;
using System.ComponentModel;

namespace CSharpInDepth.Chapter03
{
    [Description("Listing 3.16")]
    class ExtensionMethodInvocation
    {
        static void Main()
        {
            var currentInstant = DateTimeOffset.UtcNow.ToInstant();
        }
    }
}
