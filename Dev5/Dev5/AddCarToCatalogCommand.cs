namespace Dev5
{
    public class AddCarToCatalogCommand : Command
    {
        Car Car { get; set; }

        public AddCarToCatalogCommand(CatalogHelpers receiver, Car car) : base(receiver)
        {
            Car = car;
        }

        /// <summary>
        /// Executes command that adds car to catalog
        /// </summary>
        public override void Execute()
        {
            Receiver.AddToCatalog(Car);
        }
    }
}
