using System;
using System.ComponentModel;

namespace Chapter03
{
    [Description("Listing 3.5")]
    class AnonymousTypeIntro
    {
        static void Main()
        {
            var player = new
            {
                Name = "Tony",
                Score = 3500
            };
            Console.WriteLine("Player name: {0}", player.Name);
            Console.WriteLine("Player score: {0}", player.Score);
        }
    }
}
