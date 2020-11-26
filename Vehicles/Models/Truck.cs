

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUELL_CONS_INCR = 1.6;
        private const double REFUEL_SUCC_COEF = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + FUELL_CONS_INCR;

        public override void Refuel(double amount)
        {
            if (amount<=TankCapacity)
            {
                base.Refuel(amount * REFUEL_SUCC_COEF);
            }
            else
            {
                base.Refuel(amount);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
