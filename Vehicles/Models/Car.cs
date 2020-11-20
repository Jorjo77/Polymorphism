using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {//тук в класовете наследници са конкретиките (базовите функционалности са в базовия клас)
        private const double FUEL_CONSUMPTION_INCR = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption) // този конструктор не прави нищо друго освен да извика базовия с fuelQuantity и fuelConsumption)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + FUEL_CONSUMPTION_INCR;
    }
}
