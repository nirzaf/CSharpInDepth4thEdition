using System;
using System.ComponentModel;

namespace Chapter13
{
   [Description("Listing 13.22")]
    class GenerateRandomString3
    {
        static string Generate(string alphabet, Random random, int length)
        {
            Span<char> chars = stackalloc char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = alphabet[random.Next(alphabet.Length)];
            }
            return new string(chars);
        }

        static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            Console.WriteLine(Generate(alphabet, random, 10));
            Console.WriteLine(Generate(alphabet, random, 20));
        }
    }
}
