using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dev5
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        
        private const int MinAmount = 1;
        private const int MinUnitPrice = 0;

        public Car (string brand, string model, int amount, double unitPrice)
        {
            if ((brand == string.Empty) || (model == string.Empty) || (amount < MinAmount) || (unitPrice <= MinUnitPrice))
            {
                throw new ArgumentException("Wrong argument.");
            }
            Brand = brand;
            Model = model;
            Amount = amount;
            UnitPrice = unitPrice;
        }
    }
}
