using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class CountTypesCommand : Command
    {
        public CountTypesCommand(CatalogHelpers reciver) : base(reciver)
        {
        }
                
        public override void Execute()
        {
            Console.WriteLine(Reciver.CountTypes());
        }
    }
}
