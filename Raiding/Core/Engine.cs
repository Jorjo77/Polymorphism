using Raiding.Factories;
using Raiding.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Raiding.Core
{
    public class Engine : IEngine
    {

        private readonly HeroFactory heroFactory;
        private ICollection<BaseHero> collection;
        public Engine()
        {
            this.heroFactory = new HeroFactory();
            this.collection = new List<BaseHero>();
        }
        public void Run()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                BaseHero hero;
                try
                {
                    if (heroType == "Druid" || heroType == "Paladin" || heroType == "Rogue" || heroType == "Warrior")
                    {
                        hero = heroFactory.CreateHero(heroName, heroType);
                        collection.Add(hero);
                    }

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            int herousPower = 0;
            foreach (var hero in collection)
            {
                herousPower+=hero.
            }
        }
    }
}
