using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter10
{
    [Description("Listing 10.6")]
    class DictionaryInitialization
    {
        static void Main()
        {
            var objectInitializer = new Dictionary<string, int>
            {
                ["A"] = 20,
                ["B"] = 30,
                ["B"] = 40
            };

            var collectionInitializer = new Dictionary<string, int>
            {
                { "A", 20 },
                { "B", 30 },
                { "B", 40 }
            };
        }
    }
}
