using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Chapter02
{
    [Description("Listing 2.18")]
    class LineReader
    {
        static IEnumerable<string> ReadLines(string path)
        {
            using (TextReader reader = File.OpenText(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        static void Main()
        {
            // Adjust the path if you're not running it from the directory
            // containing the executable...
            foreach (string line in ReadLines("../../../Program.cs"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
