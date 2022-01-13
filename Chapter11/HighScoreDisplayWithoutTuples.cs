using NodaTime;
using System;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.11")]
    class HighScoreDisplayWithoutTuples
    {
        static void DisplayHighScoreForDate(LocalDate date)
        {
            var filteredGames = Game.AllGames.Where(game => game.Date == date);
            string highestPlayer = null;
            int highestScore = -1;
            foreach (var game in filteredGames)
            {
                if (game.Score > highestScore)
                {
                    highestPlayer = game.PlayerName;
                    highestScore = game.Score;
                }
            }
            Console.WriteLine(highestPlayer == null
                ? "No games played"
                : $"Highest score was {highestScore} by {highestPlayer}");
        }

        static void Main()
        {
            DisplayHighScoreForDate(new LocalDate(2018, 5, 30));
            DisplayHighScoreForDate(new LocalDate(2018, 5, 31));
            DisplayHighScoreForDate(new LocalDate(2018, 6, 1));
        }
    }
}
