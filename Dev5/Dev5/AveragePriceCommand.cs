using System;

namespace Dev5
{
    public class AveragePriceCommand : Command
    {
        public AveragePriceCommand(CatalogHelpers receiver) : base(receiver)
        {
        }

        /// <summary>
        /// Executes command that outputs average price to console
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Receiver.AveragePrice());
        }
    }
}
