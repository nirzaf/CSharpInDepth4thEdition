using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [Description("Listing 9.10 (first half)")]
    internal static class FormattableStringFactory
    {
        internal static FormattableString Create(
            string format, params object[] arguments) =>
            new FormattableString(format, arguments);
    }
}
