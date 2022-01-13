using NodaTime;
using System;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.12")]
    class HighScoreDisplayWithTuples
    {
        static void DisplayHighScoreForDate(LocalDate date)
        {
            var filteredGames = Game.AllGames.Where(game => game.Date == date);
            (string player, int score) highest = (null, -1);
            foreach (var game in filteredGames)
            {
                if (game.Score > highest.score)
                {
                    highest = (game.PlayerName, game.Score);
                }
            }
            Console.WriteLine(highest.player == null
                ? "No games played"
                : $"Highest score was {highest.score} by {highest.player}");
        }

        static void Main()
        {
            DisplayHighScoreForDate(new LocalDate(2018, 5, 30));
            DisplayHighScoreForDate(new LocalDate(2018, 5, 31));
            DisplayHighScoreForDate(new LocalDate(2018, 6, 1));
        }
    }
}
