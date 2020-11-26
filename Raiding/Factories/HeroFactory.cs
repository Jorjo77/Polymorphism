

using Raiding.Models;
using System;
using Vehicles.Common;

namespace Raiding.Factories
{
    public class HeroFactory
    {

        public HeroFactory()//конструктор за прегледност(нищо не прави)
        {

        }
        public BaseHero CreateHero(string heroName, string heroType)
        {
            BaseHero hero;

            if (heroType == "Druid")
            {
                hero = new Druid(heroName);
            }
            else if (heroType == "Paladin")
            {
                hero = new Paladin(heroName);
            }
            else if (heroType == "Rogue")
            {
                hero = new Rogue(heroName);
            }
            else if (heroType == "Warrior")
            {
                hero = new Warrior(heroName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalideHero);
            }
            return hero;
        }
    }
}
