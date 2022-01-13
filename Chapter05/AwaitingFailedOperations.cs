using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.4")]
    class AwaitingFailedOperations
    {
        static void Main()
        {
            var task = FetchFirstSuccessfulAsync(new[] { "http://invalid.csharpindepth.com", "http://csharpindepth.com", "https://manning.com", "https://microsoft.com" });
            var result = task.GetAwaiter().GetResult();
            Console.WriteLine(result.Length);
        }

        static async Task<string> FetchFirstSuccessfulAsync(IEnumerable<string> urls)
        {
            var client = new HttpClient();
            foreach (string url in urls)
            {
                try
                {
                    return await client.GetStringAsync(url);
                }
                catch (HttpRequestException exception)
                {
                    Console.WriteLine("Failed to fetch {0}: {1}", url, exception.Message);
                }
            }
            throw new HttpRequestException("No URLs succeeded");
        }
    }
}
