using System;
using System.ComponentModel;

/* TODO: Uncomment this when the framework supports it.
namespace Chapter13
{
    [Description("Listing 13.23")]
    class GenerateRandomString4
    {
        static string Generate(string alphabet, Random random, int length) =>
            string.Create(length, (alphabet, random), (span, state) =>
            {
                var alphabet2 = state.alphabet;
                var random2 = state.random;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = alphabet2[random2.Next(alphabet2.Length)];
                }
            });

        static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            Console.WriteLine(Generate(alphabet, random, 10));
            Console.WriteLine(Generate(alphabet, random, 20));
        }
    }
}
*/
