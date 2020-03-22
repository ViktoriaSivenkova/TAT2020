using Dev3.VehicleComponents;
using System;

namespace Dev3.Vehicles
{
    /// <summary>
    /// Class for the bus vehicle.
    /// </summary>
    public class Bus : BaseVehicle
    {
        private int _maxSeatsNumber;
        const string _vehicleType = "Bus";

        public Bus(int maxSeatsNumber, Engine engine, Transmission transmission, Chassis chassis) : base(engine, chassis, transmission, _vehicleType)
        {
            MaxSeatsNumber = maxSeatsNumber;
        }

        public int MaxSeatsNumber
        {
            get
            {
                return _maxSeatsNumber;
            }            
            private set
            {
                if (value < ConstantValues.BusMinSeatsNumber)
                {
                    throw new ArgumentException($"Number of seats cannot be less than {ConstantValues.BusMinSeatsNumber}");
                }
                _maxSeatsNumber = value;
            }
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Maximum seats number : {MaxSeatsNumber}");
        }
    }
}
