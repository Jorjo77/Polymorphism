using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string name)
            : base(name)
        {
            this.Power = power;
        }

        public int Power { get; }

        public override string CastAbility()
        {
            return $"Druid – {this.GetType().Name} – {this.Name} healed for {this.Power}";
        }
    }
}
