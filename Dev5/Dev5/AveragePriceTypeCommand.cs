using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class AveragePriceTypeCommand : Command
    {
        private string Brand { get; set; }

        public AveragePriceTypeCommand(WorkWithCatalog reciver, string brand) : base(reciver)
        {
            Brand = brand;
        }   

        public override void Execute()
        {
            Console.WriteLine(Reciver.AveragePriceType(Brand));
        }
    }
}
