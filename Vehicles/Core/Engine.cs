
using System;
using Vehicles.Core.Contracts;
using Vehicles.Factories;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {

        private readonly VehicleFactory vehicleFactory;
        public Engine()
        {
            this.vehicleFactory = new VehicleFactory();
        }
        public void Run()
        {
            Vehicle car = ProcessVehicleInfo();
            Vehicle truck = ProcessVehicleInfo();
            Vehicle bus = ProcessVehicleInfo();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                string vehicleType = cmdArg[1];
                //Can be liters or kilometers
                double arg = double.Parse(cmdArg[2]);

                try
                {
                    if (vehicleType == "Car")
                    {
                        DoTheAction(car, cmdType, vehicleType, arg);
                    }
                    else if (vehicleType == "Truck")
                    {
                        DoTheAction(truck, cmdType, vehicleType, arg);
                    }
                    else
                    {
                        DoTheAction(bus, cmdType, vehicleType, arg);
                    }

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());

        }

        private static void DoTheAction(Vehicle vehicle, string action, string vecihleType, double amount)
        {
            if (action == "DriveEmpty")
            {
                vehicle.IsEmpty = true;
                Console.WriteLine(vehicle.Drive(amount));
            }
            else if (action == "Drive")
            {
                Console.WriteLine(vehicle.Drive(amount));
            }
            else
            {
                vehicle.Refuel(amount);
            }
        }

        //It will create valide type vehicle by given information
        private Vehicle ProcessVehicleInfo()//този метод се явява просто посредник: чете, дава на този който може да направи Vehicle и после го връща! - това е съгласно СОЛИД принципите.
        {
            string[] vehicleArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string vehicleType = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);
            double tankCapacity = double.Parse(vehicleArgs[3]);

            Vehicle currentVehicle = vehicleFactory.CreateVehicle(vehicleType, fuelQuantity, fuelConsumption, tankCapacity);

            return currentVehicle;
        }
    }
}

