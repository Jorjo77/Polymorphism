using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models.Contracts
{
    public interface IRefulable
    {
        public double TankCapacity { get; }
        public void Refuel(double amount);
    }
}
