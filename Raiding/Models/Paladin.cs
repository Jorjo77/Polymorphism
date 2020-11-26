using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero, IPaladin
    {
        private const int PaladinPower = 100;
        public Paladin(string name)
            : base(name)
        {
            this.Power = PaladinPower;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"healed for {Power}"; 
        }
    }
}
