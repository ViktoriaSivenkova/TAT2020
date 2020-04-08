using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class AddCarToCatalogCommand : Command
    {
        private Func<Car> getCarFromConsole;

        Car Car { get; set; }

        public AddCarToCatalogCommand(WorkWithCatalog reciver, Car car) : base(reciver)
        {
            Car = car;
        }

        public AddCarToCatalogCommand(WorkWithCatalog reciver, Func<Car> getCarFromConsole) : base(reciver)
        {
            this.getCarFromConsole = getCarFromConsole;
        }

        public override void Execute()
        {
            Reciver.AddToCatalog(Car);
        }
    }
}
