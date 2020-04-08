using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class AddCarToCatalogCommand : Command
    {
        Car Car { get; set; }

        public AddCarToCatalogCommand(CatalogHelpers reciver, Car car) : base(reciver)
        {
            Car = car;
        }        

        public override void Execute()
        {
            Reciver.AddToCatalog(Car);
        }
    }
}
