

using Raiding.Models.Contracts;

namespace Raiding.Models
{
    public class Druid : BaseHero, IDruid
    {
        private  const int DruidPower = 80;
        public Druid(string name) 
            : base(name)
        {
            this.Power = DruidPower;
        }

        public override string CastAbility()
        {
            return base.CastAbility() + $"healed for {Power}";
        }
    }
}
