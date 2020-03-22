using Dev3.VehicleComponents;
using System;

namespace Dev3.Vehicles
{
    /// <summary>
    /// Class for the scooter vehicle.
    /// </summary>
    public class Scooter : BaseVehicle
    {
        private int _maxSpeed;
        const string _vehicleType = "Scooter";

        public Scooter(int maxSpeed, Engine engine, Transmission transmission, Chassis chassis) : base(engine, chassis, transmission, _vehicleType)
        {
            MaxSpeed = maxSpeed;
        }

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }            
            private set
            {
                if (value < ConstantValues.MinScooterSpeed)
                {
                    throw new ArgumentException($"Max scooter speed cannot be less than {ConstantValues.MinScooterSpeed}");
                }
                _maxSpeed = value;
            }
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Scooter maximum speed: {MaxSpeed}");
        }
    }
}
