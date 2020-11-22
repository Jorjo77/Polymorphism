
using System;
using System.Collections.Generic;

using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Han : Bird
    {
        public Han(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => 0.35;

        public override ICollection<Type> PreferredFoods => new List<Type>() {typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds)};

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
