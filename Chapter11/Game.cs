using NodaTime;
using System.Collections.Generic;

namespace Chapter11
{
    // Used by listings 11.11 and 11.12
    class Game
    {
        public string PlayerName { get; }
        public int Score { get; }
        public LocalDate Date { get; }

        private Game(string playerName, int score, LocalDate date)
        {
            PlayerName = playerName;
            Score = score;
            Date = date;
        }

        public static IEnumerable<Game> AllGames { get; } = new[]
        {
            new Game("Fiona", 10, new LocalDate(2018, 5, 31)),
            new Game("Jorge", 30, new LocalDate(2018, 5, 31)),
            new Game("Don", 20, new LocalDate(2018, 5, 31)),
            new Game("Jemima", 45, new LocalDate(2018, 6, 1)),
            new Game("Rosie", 35, new LocalDate(2018, 6, 1)),
        };
    }
}
