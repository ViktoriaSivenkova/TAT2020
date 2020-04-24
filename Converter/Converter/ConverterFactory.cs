using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class ConverterFactory
    {        
        public BaseConverter Converter { get; set; }
               

        public BaseConverter GetConverter(double number, string formatConversion)
        {
            switch (formatConversion.ToUpper())
            {
                case "CP":
                    Converter = new TemperatureConverter(number, formatConversion);
                    return Converter;
                case "PC":
                    Converter = new TemperatureConverter(number, formatConversion);
                    return Converter;
                case "MF":
                    Converter = new LengthConverter(number, formatConversion);
                    return Converter;
                case "FM":
                    Converter = new LengthConverter(number, formatConversion);
                    return Converter;
                default:
                    throw new Exception("Invalid conversion format");

            }
        }
    }
    
}
