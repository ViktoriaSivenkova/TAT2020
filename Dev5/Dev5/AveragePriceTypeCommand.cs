using System;

namespace Dev5
{
    public class AveragePriceTypeCommand : Command
    {
        private string Brand { get; set; }

        public AveragePriceTypeCommand(CatalogHelpers receiver, string brand) : base(receiver)
        {
            Brand = brand;
        }


        /// <summary>
        /// Executes command that outputs average price type to console
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Receiver.AveragePriceType(Brand));
        }
    }
}
