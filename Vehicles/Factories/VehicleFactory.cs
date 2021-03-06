﻿

using System;
using Vehicles.Common;
using Vehicles.Models;

namespace Vehicles.Factories
{
    public class VehicleFactory
    {
        public VehicleFactory()//конструктор за прегледност(нищо не прави)
        {

        }
        public Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumption, double tankCapacity)//Това е фактори Factory Design pattern 
        {
            Vehicle vehicle;

            if (vehicleType == "Car")//по принцип не се пише точно така, но не знаем още рефлекшън!
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }

            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Bus")
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalideVehicleType);
            }

            return vehicle;
        }
    }
}
