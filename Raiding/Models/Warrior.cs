using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero, IWarrior
    {
        private const int WarriorPower = 100;
        public Warrior(string name)
            : base(name)
        {
            this.Power = WarriorPower;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"hit for {this.Power} damage"; 
        }
    }

}
