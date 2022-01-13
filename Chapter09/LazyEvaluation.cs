using System;

namespace Chapter09
{
    class LazyEvaluation
    {
        static void Main()
        {
            // Never use this code. It's here for amusement, that's all.
            string value = "Before";
            FormattableString formattable = $"Current value: {_(() => value)}";
            Console.WriteLine(formattable);

            value = "After";
            Console.WriteLine(formattable);
        }

#pragma warning disable IDE1006 // Naming Styles
        static Capture _(Func<object> provider)
#pragma warning restore IDE1006 // Naming Styles
        {
            return new Capture(provider);
        }
    }

    class Capture : IFormattable
    {
        private readonly Func<object> provider;

        public Capture(Func<object> provider)
        {
            this.provider = provider;
        }

        public override String ToString()
        {
            return base.ToString();
        }

        public String ToString(string format, IFormatProvider formatProvider)
        {
            object value = provider();
            if (value == null)
            {
                return "";
            }
            var formattable = value as IFormattable;
            return formattable == null ? value.ToString() : formattable.ToString(format, formatProvider);
        }
    }
}
