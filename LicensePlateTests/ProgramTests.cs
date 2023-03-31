using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Test1()
        {
            Assert.IsTrue(Program.LicensePlate("5F3Z-2e-9-w", 4) == "5F3Z-2E9W");
        }

        [TestMethod()]
        public void Test2()
        {
            Assert.IsTrue(Program.LicensePlate("2-5g-3-J", 2) == "2-5G-3J");
        }

        [TestMethod()]
        public void Test3()
        {
            Assert.IsTrue(Program.LicensePlate("2-4A0r7-4k", 3) == "24-A0R-74K");
        }

        [TestMethod()]
        public void Test4()
        {
            Assert.IsTrue(Program.LicensePlate("nlj-206-fv", 3) == "NL-J20-6FV");
        }
    }
}