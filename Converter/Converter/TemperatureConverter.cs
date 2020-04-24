using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class TemperatureConverter : BaseConverter
    {
        public TemperatureConverter(double number, string converterType) : base(number, converterType)
        {

        }
        public double ConverterCelsiusToPharyngate()
        {
            return ((9.0 / 5.0) * Number) + 32;
        }

        public double ConverterPharyngateToCelsius()
        {
            return (5.0 / 9.0) * (Number - 32);
        }

        public override void ChoiceConverterType(string type)
        {
            switch (type.ToUpper())
            {
                case "CP":
                    Result = ConverterCelsiusToPharyngate();
                    break;
                case "PC":
                    Result = ConverterPharyngateToCelsius();
                    break;               
            }
        }
    }
}
