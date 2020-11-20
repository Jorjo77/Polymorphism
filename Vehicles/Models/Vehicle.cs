﻿

using System;
using Vehicles.Common;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDrivable, IRefulable
    {//когато мислим за абстрактния клас трябва да мислим за всички функционалности общо, как би трябвало да се държат в общия случай, конкретиката ще се разписва надолу по наследниците!!! 
        private const string SUCC_DRIVED_MSG = "{0} travelled {1} km";

        protected Vehicle(double fuelQuantity, double fuelConsumption)//protected (не public), защото abstract class не може да се инстанцира и ще се ползва само от наследените класове
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity { get; private set; }
        public virtual double FuelConsumption { get; }

        public string Drive(double amount)
        {
            double fuelNeeded = amount * this.FuelConsumption;
            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;
            return String.Format(SUCC_DRIVED_MSG, this.GetType().Name, amount);
        }
        public virtual void Refuel(double amount)//базовия метод е това (общ, надолу децата да си го екстендват)
        {
            if (amount <= 0 )
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughFuel);
            }
            this.FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}