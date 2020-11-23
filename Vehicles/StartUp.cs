

using Vehicles.Core;
using Vehicles.Core.Contracts;

namespace Vehicles
{
    public class StartUp
    {

        //To extend the Vehicles:
//1.Add a new vehicle – Bus. - a new Class
//2. Add to every vehicle a new property – tank capacity + validation - If you try to put more fuel - throw ArgExepMsg "Cannot fit {fuel amount} fuel in the tank"and do not add any fuel
// If you try to create a vehicle with more fuel than its tank capacity, create it but start with an empty tank.
//3.Add a new command for the bus. (Maby in Engine!?)
//You can drive the bus with or without people.With people, the air-conditioner is turned on and its fuel consumption per kilometer is increased by 1.4 liters.If there are no people in the bus, the air-conditioner is turned off and does not increase the fuel consumption.

        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
