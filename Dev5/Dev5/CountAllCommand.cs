using System;

namespace Dev5
{
    public class CountAllCommand : Command
    {
        public CountAllCommand(CatalogHelpers receiver) : base(receiver)
        {
        }

        /// <summary>
        /// Executes command that outputs count of cars in catalog to console
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Receiver.CountAll());
        }
    }
}
