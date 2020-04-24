using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public abstract class BaseConverter
    {
        public double Result { get; set; }
        public double Number { get; set; }
        public string ConverterType { get; set; }

        public BaseConverter(double number, string converterType)
        {
            Number = number;
            ConverterType = converterType;
        }
        public abstract void ChoiceConverterType(string type);
        
    }
}
