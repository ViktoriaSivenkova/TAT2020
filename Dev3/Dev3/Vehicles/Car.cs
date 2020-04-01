using Dev3.VehicleComponents;
using System;

namespace Dev3.Vehicles
{
    /// <summary>
    /// Class for the car vehicle.
    /// </summary>
    public class Car : BaseVehicle
    {
        private string _model;
        private string _color;
        const string _vehicleType = "Car";

        public Car(string model, string color, Engine engine, Transmission transmission, Chassis chassis) : base(engine, chassis, transmission, _vehicleType)
        {
            Model = model;
            Color = color;
        }

        public string Model
        {
            get
            {
                return _model;
            }            
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(Model)) == false 
                    && StringHelpers.IsLatinAndNumericString(value, nameof(Model)) == true)
                {
                    _model = value;
                }
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }            
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(Color)) == false &&
                    StringHelpers.IsLatinAndNumericString(value, nameof(Color)) == true)
                {
                    _color = value;
                }
            }
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Car model : {Model}");
            Console.WriteLine($"Car color: {Color}");
        }
    }
}
