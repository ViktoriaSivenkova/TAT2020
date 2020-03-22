using System;

namespace Dev3.VehicleComponents
{
    /// <summary>
    /// Class for the transmission vehicle component.
    /// </summary>
    public class Transmission : IInfo
    {
        private string _type;
        private int _gearsNumber;
        private string _vendor;

        public Transmission(string type, int gearsNumber, string vendor)
        {
            Type = type;
            GearsNumber = gearsNumber;
            Vendor = vendor;
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

        public int GearsNumber
        {
            get
            {
                return _gearsNumber;
            }            
            private set
            {
                if (value < ConstantValues.MinGearsNumber)
                {
                    throw new ArgumentException($"Gears number cannot be less than {ConstantValues.MinGearsNumber}");
                }
                _gearsNumber = value;
            }
        }

        public string Vendor
        {
            get
            {
                return _vendor;
            }            
            private set
            {
                if (StringHelpers.IsNullOrEmptyString(value, nameof(Vendor)) == false 
                    && StringHelpers.IsLatinAndNumericString(value, nameof(Vendor)) == true)
                {
                    _vendor = value;
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Transmission type : {Type}");
            Console.WriteLine($"Gears number : {GearsNumber}");
            Console.WriteLine($"Transmission vendor : {Vendor}");
        }
    }
}
