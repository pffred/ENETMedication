using System;
using ENETClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENETClasses.LocationClasses;
using System.Collections.Generic;
using ENETClasses.Package;
using ENETClasses.EntityInteraction.Reports;
using ENETClasses.Employee;

namespace ENETTests
{
    [TestClass]
    public class InformationSwapTests
    {

        [TestMethod]
        public void DistributionCentre_PackageValueOfPackages()
        {
            PackageItem p = new PackageItem(100, "Pills", 100);
            var p1 = new PackageItem(1, "Something cool", 1000);
            var p2 = new PackageItem(25, "Something fairly normal", 1);
            DistributionCentre d = new DistributionCentre("Blank", "Nowhere", "1");
            d.Packages = new List<PackageItem>() { p, p1, p2 };
            DistributionCentreStock report = new DistributionCentreStock(d);
            Assert.AreEqual(report.TotalStockValue, 10125);
        }

        [TestMethod]
        public void Location_BetweenDistributionCentres_CorrectlyPrints()
        {
            var loc1 = new DistributionCentre("Centre A", "Up the road", "1");
            var loc2 = new DistributionCentre("Centre B", "Down the road", "2");

            var route = new RouteBetweenCentres(loc1, loc2);

            Assert.AreEqual(route.ReportOutput, "Enroute from Centre A to Centre B"); // For example
        }


        [TestMethod]
        public void Employee_FullName_CorrectlyOutputsToReport()
        {
            var emp1 = new Doctor("John", "Doe", "JDnTurk");
            Assert.AreEqual(emp1.Fullname, "John Doe");
        }

        
    }
}
