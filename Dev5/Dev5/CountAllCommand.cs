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
                
        public override void Execute()
        {
            Console.WriteLine(Reciver.CountAll());
        }
    }
}
