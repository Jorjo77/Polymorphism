

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

            if (vehicleType == "Car"&& fuelQuantity<=tankCapacity)//по принцип не се пише точно така, но не знаем още рефлекшън!
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Car" && fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0d;
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Truck" && fuelQuantity <= tankCapacity)
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Truck" && fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0d;
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Bus" && fuelQuantity <= tankCapacity)
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Bus" && fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0d;
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
