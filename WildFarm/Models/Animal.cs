
using System;
using System.Collections.Generic;

using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal 
        : IAnimal, IFeedable, ISoundProduceble
    {
        private const string INV_FOOD_TYPE = "{0} does not eat {1}!";
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract double WeightMultiplier { get; }//с abstract задължавам всеки надолу да имплементира какъв му е мултиплайера!

        public abstract ICollection<Type> PreferredFoods { get; }//abstract защото надолу за всяко животно ще е различна!

        public void Feed(IFood food)
        {
            if (!this.PreferredFoods.Contains(food.GetType()))
            {
                throw new InvalidOperationException(string.Format(INV_FOOD_TYPE, this.GetType().Name, food.GetType().Name));
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.WeightMultiplier;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
