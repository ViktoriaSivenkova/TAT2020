using System;

namespace Dev5
{
    public class CountTypesCommand : Command
    {
        public CountTypesCommand(CatalogHelpers receiver) : base(receiver)
        {
        }

        /// <summary>
        /// Executes command that outputs count of cars type in catalog to console
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Receiver.CountTypes());
        }
    }
}
