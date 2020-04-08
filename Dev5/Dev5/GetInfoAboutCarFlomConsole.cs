using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class GetInfoAboutCarFlomConsole
    {
        public Car GetCarFromConsole()
        {
            Console.WriteLine("Input car brand");
            string brand = Console.ReadLine();

            Console.WriteLine("Input car model");
            string model = Console.ReadLine();

            Console.WriteLine("Input car price");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Input car count");
            int count = int.Parse(Console.ReadLine());

            return new Car(brand, model, count, price);
        }
        public string GetBrand()
        {
            Console.WriteLine("Input car brand");
            return Console.ReadLine();
        }
    }


}
