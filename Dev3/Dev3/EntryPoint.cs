using Dev3.VehicleComponents;
using Dev3.Vehicles;
using System;

namespace Dev3
{
    public class EntryPoint
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                var carEngine = new Engine(150, 1500, "Heat", "T34GDS543FDSH");
                var carChassis = new Chassis(4, "FJDSJ3242", 1000);
                var carTransmission = new Transmission("Automatic", 8, "ZF");
                var car = new Car("Volkswagen", "black", carEngine, carTransmission, carChassis);
                car.GetInfo();

                var truckEngine = new Engine(500, 5000, "Heat", "Y547FDSH432");
                var truchChassis = new Chassis(6, "GFJ534532KGFS", 20000);
                var truckTransmission = new Transmission("Manual", 6, "Tremec");
                var truck = new Truck("Flat", 20000, truckEngine, truckTransmission, truchChassis);
                truck.GetInfo();
            }

            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message); // Output any exception message to console.
            }
        }
    }
}