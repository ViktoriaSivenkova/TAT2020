using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public abstract class  Command
    {
        protected CatalogHelpers Reciver;

        public Command(CatalogHelpers reciver)
        {
            Reciver = reciver;
        }
        public abstract void Execute();
    }
}
