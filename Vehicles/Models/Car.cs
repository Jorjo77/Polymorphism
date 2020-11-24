

namespace Vehicles.Models
{
    public class Car : Vehicle
    {//тук в класовете наследници са конкретиките (базовите функционалности са в базовия клас)
        private const double FUEL_CONSUMPTION_INCR = 0.9;
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)// този конструктор не прави нищо друго освен да извика базовия с fuelQuantity, fuelConsumption и tankCapacity)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + FUEL_CONSUMPTION_INCR;

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
