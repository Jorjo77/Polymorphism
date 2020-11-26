using Raiding.Factories;
using Raiding.Models;
using Raiding.Models.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Raiding.Core
{
    public class Engine : IEngine
    {

        private readonly HeroFactory heroFactory;
        private readonly ICollection<IHero> raid;

        private IHero hero;
        public Engine()
        {
            hero = null;
            heroFactory = new HeroFactory();
            raid = new List<IHero>();
        }
        public void Run()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                
                try
                {
                    if (heroType == "Druid" || heroType == "Paladin" || heroType == "Rogue" || heroType == "Warrior")
                    {
                        hero = heroFactory.CreateHero(heroName, heroType);
                        if (hero != null)
                        {
                            raid.Add(hero);
                        }

                    }

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            int herousPower = raid.Sum(x=>x.Power);

            CastAbilitiesAll();

            if (herousPower>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private void CastAbilitiesAll()
        {
            foreach (var hero in raid)
            {
                Console.WriteLine(hero.CastAbility());
            }
        }
    }
}
