using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests
{
    [TestClass()]
    public class DataConverterTests
    {
        DataConverter converter = null;

        [TestCleanup()]
        public void Cleanup()
        {
            converter = null;
        }

        [TestMethod()]
        public void mb_kb()
        {
            converter = new DataConverter("mb", "kb");
            double valL = 1;
            double valR = 1024;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }
    }
}
