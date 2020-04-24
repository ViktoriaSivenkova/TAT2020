using System;

namespace Converter
{
    public class EntryPoint
    {
       
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(args[0]);
            string type = args[1];
            
            var ConverterFactory = new ConverterFactory();
            var Converter = ConverterFactory.GetConverter(number, type);
            Converter.ChoiceConverterType(type);
            Console.WriteLine(Converter.Result);

        }
    }
}
