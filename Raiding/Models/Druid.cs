

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int power = 80;
        public Druid(string name) 
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
