using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class FootbalGame : Game
    {
        private List<Player> team;

        public FootbalGame()
        {
            team = new List<Player>();
        }

        public override string GetDescription()
        {
            return $"The team god mad and got in a fight";
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Footbal game starting");
            Console.WriteLine("Play himn");
        }

        public override void Stop()
        {
            base.Stop();
            Console.WriteLine("Get in a fight");
        }
    }
}
