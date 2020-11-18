using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Tennis : TwoPlayerGame
    {
        public Tennis(Player playerOne, Player playerTwo)
            : base(playerOne, playerTwo)
        {}
        public override string GetDescription()
        {
            return $"{playerOne} broke his racket {playerTwo} hit the judje";
        }

        public string IsGrandSlam()
        {
            return $"Grandslam is the best";
        }
    }
}
