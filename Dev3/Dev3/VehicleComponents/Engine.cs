using System;

namespace Dev3.VehicleComponents
{
    /// <summary>
    /// Class for the engine vehicle component.
    /// </summary>
    public class Engine : IInfo
    {
        private double _power;
        private double _volume;
        private string _type;
        private string _serialNumber;

        public Engine(double power, double volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        public double Power
        {
            get
            {
                return _power;
            }
            private set
            {
                if (value < ConstantValues.MinEnginePower)
                {
                    throw new ArgumentException($"Engine power cannot be less than {ConstantValues.MinEnginePower}");
                }
                _power = value;
            }
        }
        public double Volume
        {
            get
            {
                return _volume;
            }
            private set
            {
                if (value < ConstantValues.MinEngineVolume)
                {
                    throw new ArgumentException($"Engine volume cannot be less than {ConstantValues.MinEngineVolume}");
                }
                _volume = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(Type)) == false 
                    && StringHelpers.IsLatinAndNumericString(value, nameof(Type)) == true)
                {
                    _type = value;
                }
            }
        }
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(SerialNumber)) == false 
                    && StringHelpers.IsLatinAndNumericString(value, nameof(SerialNumber)) == true)
                {
                    _serialNumber = value;
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Engine power : {Power}");
            Console.WriteLine($"Engine volume : {Volume}");
            Console.WriteLine($"Engine type : {Type}");
            Console.WriteLine($"Engine serial number : {SerialNumber}");
        }
    }
}
