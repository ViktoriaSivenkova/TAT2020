using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class CountAllCommand : Command
    {
        public CountAllCommand(WorkWithCatalog reciver) : base(reciver)
        {
        }

        /// <summary>
        /// Executes command that outputs count of cars in catalog to console
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Reciver.CountAll());
        }
    }
}
