using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamesMagazine games = new GamesMagazine();
            games.AddGame(new FootbalGame());
            games.AddGame(new ChessGame(new Player("Fisher"), new Player("Spassky")));
            //games.AddGame(new Tennis())
            games.AddGame(new Tennis(new Player("Federer"), new Player("Nadal")));
            games.StartGames();
            games.StopGames();
            games.PrintDescriptions();

        }
    }
}
