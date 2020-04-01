using Dev3.VehicleComponents;
using System;

namespace Dev3.Vehicles
{
    /// <summary>
    /// Class for the truck vehicle.
    /// </summary>
    public class Truck : BaseVehicle
    {
        private string _bodyType;
        private int _carryingCapacity;
        const string _vehicleType = "Truck";

        public Truck(string bodyType, int carryingCapacity, Engine engine, Transmission transmission, Chassis chassis) : base(engine, chassis, transmission, _vehicleType)
        {
            BodyType = bodyType;
            CarryingCapacity = carryingCapacity;
        }

        public string BodyType
        {
            get
            {
                return _bodyType;
            }            
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(BodyType)) == false
                    && StringHelpers.IsLatinAndNumericString(value, nameof(BodyType)) == true)
                {
                    _bodyType = value;
                }
            }
        }

        public int CarryingCapacity
        {
            get
            {
                return _carryingCapacity;
            }            
            private set
            {
                if (value < ConstantValues.MinCarryingCapacity)
                {
                    throw new ArgumentException($"Carrying capacity cannot be less than {ConstantValues.MinCarryingCapacity}");
                }
                _carryingCapacity = value;
            }
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Truck body type: {BodyType}");
            Console.WriteLine($"Truck carrying capaity: {CarryingCapacity}");
        }
    }
}
