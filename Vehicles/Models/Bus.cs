

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double FUELL_CONS_INCR = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override bool IsEmpty { get; set; }

        public override double FuelConsumption
        {
            get
            {
                if (!IsEmpty)
                {
                    return base.FuelConsumption + FUELL_CONS_INCR;
                }

                return base.FuelConsumption;
            }
        }

        public override void Refuel(double amount)
            => base.Refuel(amount);

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
