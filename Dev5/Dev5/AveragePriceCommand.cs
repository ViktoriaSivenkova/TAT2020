﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    public class AveragePriceCommand : Command
    {
        public AveragePriceCommand(WorkWithCatalog reciver) : base(reciver)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(Reciver.AveragePrice());
        }
    }
}
