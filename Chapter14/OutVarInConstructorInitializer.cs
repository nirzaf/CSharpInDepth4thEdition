using System;
using System.ComponentModel;

namespace Chapter14
{
    class ParsedText
    {
        public string Text { get; }
        public bool Valid { get; }

        protected ParsedText(string text, bool valid)
        {
            Text = text;
            Valid = valid;
        }
    }

    class ParsedInt32 : ParsedText
    {
        public int? Value { get; }

        public ParsedInt32(string text) : base(text, int.TryParse(text, out int parseResult))
        {
            Value = Valid ? parseResult : (int?) null;
        }

        public override string ToString() => $"Text: {Text}; Valid: {Valid}; Value: {Value}";
    }

    [Description("Listing 14.10")]
    class OutVarInConstructorInitializer
    {
        static void Main()
        {
            Console.WriteLine(new ParsedInt32("bad"));
            Console.WriteLine(new ParsedInt32("123"));
        }
    }
}
