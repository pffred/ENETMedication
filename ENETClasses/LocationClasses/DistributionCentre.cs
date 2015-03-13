﻿using ENETClasses.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENETClasses.LocationClasses
{
    class DistributionCentre : ILocation
    {
        public List<PackageItem> Packages { get; set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }


    }
}
