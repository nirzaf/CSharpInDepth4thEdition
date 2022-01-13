using System;
using System.ComponentModel;
using System.Net.Http;

namespace Chapter03
{
    [Description("Listing 3.4")]
    class NestedObjectInitializer
    {
        static void Main()
        {
            HttpClient client = new HttpClient
            {
                DefaultRequestHeaders =
                {
                    From = "user@example.com",
                    Date = DateTimeOffset.UtcNow
                }
            };
        }
    }
}
