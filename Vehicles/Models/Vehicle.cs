

using System;
using Vehicles.Common;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{

    public abstract class Vehicle : IDrivable, IRefulable
    {//когато мислим за абстрактния клас трябва да мислим за всички функционалности общо, как би трябвало да се държат в общия случай, конкретиката ще се разписва надолу по наследниците!!! 
        private const string CANNOT_FIT_FUEL_QUANTITY = "Cannot fit {0} fuel in the tank";
        private double fuelQuantity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)//protected (не public), защото abstract class не може да се инстанцира и ще се ползва само от наследените класове
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }
        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }
        public virtual double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }
        public virtual bool IsEmpty { get; set; }
        public virtual string Drive(double amount)
        {
            double fuelNeeded = amount * FuelConsumption;
            if (FuelQuantity < fuelNeeded)
            {
                return String.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name);
            }

            this.FuelQuantity -= fuelNeeded;
            return String.Format(ExceptionMessages.Succ_Drived_Msg, this.GetType().Name, amount);
        }


        public virtual void Refuel(double amount)//базовия метод е това (общ, надолу децата да си го екстендват)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NegativeFuel);
            }
            else if (amount + fuelQuantity > TankCapacity)
            {
                throw new InvalidOperationException(String.Format(CANNOT_FIT_FUEL_QUANTITY, amount));
            }

            IsEmpty = false;


            FuelQuantity += amount;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
