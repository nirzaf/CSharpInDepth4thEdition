using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.6")]
    class DynamicJsonParsing
    {
        static void Main()
        {
            string json = @"
                {
                  'name': 'Jon Skeet',
                  'address': { 
                    'town': 'Reading',
                    'country': 'UK'
                  }
                }".Replace('\'', '"');

            JObject obj1 = JObject.Parse(json);
            Console.WriteLine(obj1["address"]["town"]);

            dynamic obj2 = obj1;
            Console.WriteLine(obj2.address.town);
        }
    }
}
