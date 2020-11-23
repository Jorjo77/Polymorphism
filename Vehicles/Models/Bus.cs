using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }
    }
}
