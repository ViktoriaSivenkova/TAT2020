using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class LengthConverter : BaseConverter
    {
        public LengthConverter(double number, string converterType) : base (number, converterType)
        {
            
        }

        public double ConverterMetersToFeet()
        {
            return Number / 0.304800610;
        }
        public double ConverterFeetToMeters()
        {
            return Number * 0.304800610;
        }

        public override void ChoiceConverterType(string type) 
        {
            switch (type.ToUpper())
            {                
                case "MF":
                    Result = ConverterMetersToFeet();
                    break;
                case "FM":
                    Result = ConverterFeetToMeters();
                    break;
            }
        }
    }
}
