﻿using ENETClasses.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.EntityInteraction.Reports
{
    class DistributionCentreStock : IReport
    {
        public AustralianDollar TotalStockValue { get; set; }
        public int TotalStockCount { get; set; }

    }
}
