using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.4")]
    class InvalidCalls
    {
        static void Main()
        {
            /* All these calls are invalid
            dynamic d = new object();
            int invalid1 = "text".Substring(0, 1, 2, d);
            bool invalid2 = string.Equals<int>("foo", d);
            string invalid3 = new string(d, "broken");
            char invalid4 = "text"[d, d];
            */
        }
    }
}
