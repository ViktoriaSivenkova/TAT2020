using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public abstract class  Command
    {
        protected WorkWithCatalog Reciver;

        public Command(WorkWithCatalog reciver)
        {
            Reciver = reciver;
        }
        public abstract void Execute();
    }
}
