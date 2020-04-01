using System;

namespace Dev3.VehicleComponents
{
    /// <summary>
    /// Class for the chassis vehicle component.
    /// </summary>
    public class Chassis : IInfo
    {
        private int _wheelsAmount;
        private string _number;
        private double _allowableLoad;

        public Chassis(int wheelsAmount, string number, double allowableLoad)
        {
            WheelsAmount = wheelsAmount;
            Number = number;
            AllowableLoad = allowableLoad;
        }

        public int WheelsAmount
        {
            get
            {
                return _wheelsAmount;
            }            
            private set
            {
                if (value < ConstantValues.MinWheelsAmount)
                {
                    throw new ArgumentException($"Wheels amount cannot be less than {ConstantValues.MinWheelsAmount}");
                }
                _wheelsAmount = value;
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }            
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(Number)) == false 
                    && StringHelpers.IsLatinAndNumericString(value, nameof(Number)) == true)
                {
                    _number = value;
                }
            }
        }

        public double AllowableLoad
        {
            get
            {
                return _allowableLoad;
            }
            private set
            {
                if (value < ConstantValues.MinAllowableLoad)
                {
                    throw new ArgumentException($"Allowable load cannot be less than {ConstantValues.MinAllowableLoad}");
                }
                _allowableLoad = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Chassis wheels amount : {WheelsAmount}");
            Console.WriteLine($"Chassis number : {Number}");
            Console.WriteLine($"Chassis allowable load : {AllowableLoad}");
        }
    }
}
