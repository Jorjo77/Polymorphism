
using System;
using System.Linq;
using System.Reflection;
using WildFarm.Common;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public Food CeateFood(string strType, int quantity)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == strType);

            if (type == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidType);
            }

            object[] ctorParms = new object[] { quantity };

            Food food = (Food)Activator.CreateInstance(type, ctorParms);

            return food;
        }
    }
}
