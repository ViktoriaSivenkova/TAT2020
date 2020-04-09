namespace Dev5
{
    public abstract class  Command
    {
        protected CatalogHelpers Receiver;

        public Command(CatalogHelpers receiver)
        {
            Receiver = receiver;
        }
        public abstract void Execute();
    }
}
