using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.2")]
    class ReturnFromAsync
    {
        static readonly HttpClient client = new HttpClient();

        static async Task<int> GetPageLengthAsync(string url)
        {
            Task<string> fetchTextTask = client.GetStringAsync(url);
            int length = (await fetchTextTask).Length;
            return length;
        }

        static void PrintPageLength()
        {
            Task<int> lengthTask =
               GetPageLengthAsync("http://csharpindepth.com");
            Console.WriteLine(lengthTask.Result);
        }

        static void Main()
        {
            PrintPageLength();
        }
    }
}
