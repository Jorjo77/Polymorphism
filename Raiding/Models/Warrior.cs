using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int power = 100;
        public Warrior(string name)
            : base(name)
        {
            this.Power = power;
        }

        public int Power { get; }

        public override string CastAbility()
        {
            return $"Warrior – {this.GetType().Name} – {this.Name} hit for {this.Power} damage";
        }
    }

}
