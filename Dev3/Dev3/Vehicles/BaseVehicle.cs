using Dev3.VehicleComponents;
using System;

namespace Dev3.Vehicles
{
    /// <summary>
    /// Base class for vehicles(Bus,Car,Scooter,Truck).
    /// </summary>
    public abstract class BaseVehicle : IInfo
    {
        protected BaseVehicle(Engine engine, Chassis chassis, Transmission transmission, string vehicleType)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            VehicleType = vehicleType;
        }

        /// <summary>
        /// Gets info for the current vehicle.
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"\n Vehicle type is {VehicleType} and specs are next:");
            Engine.GetInfo();
            Chassis.GetInfo();
            Transmission.GetInfo();
        }

        public Engine Engine { get; private set; }
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; private set; }
        public string VehicleType { get; private set; }
    }
}
