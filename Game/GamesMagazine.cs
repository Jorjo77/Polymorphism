using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class GamesMagazine
    {
        private List<Game> games;

        public GamesMagazine()
        {
            games = new List<Game>(); 
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void StartGames()
        {
            foreach (var game in games)
            {
                game.Start();
            }
        }

        public void StopGames()
        {
            foreach (var game in games)
            {
                game.Stop();
            }
        }

        public void PrintDescriptions()
        {
            foreach (var game in games)
            {
                //if (game is Tennis)
                //{
                //    Console.WriteLine(((Tennis)game).IsGrandSlam());
                //}
                //if (game is ChessGame)
                //{

                //}така започнем ли, губим абстракцията и не е добре!!!!!
                Console.WriteLine(game.GetDescription());
            }
        }
    }
}
