using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class CountTypesCommand : Command
    {
        public CountTypesCommand(WorkWithCatalog reciver) : base(reciver)
        {
        }

        /// <summary>
        /// Executes command that outputs count of brands to console
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Reciver.CountTypes());
        }
    }
}
