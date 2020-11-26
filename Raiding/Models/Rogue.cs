using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero, IRogue
    {
        private const int RoguePower = 80;
        public Rogue(string name)
            : base(name)
        {
            this.Power = RoguePower;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"hit for {Power} damage"; 
        }
    }
}
