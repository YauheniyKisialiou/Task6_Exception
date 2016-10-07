using ConvertToInt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void CheckPosetiveNumber()
        {
            string str = "124";
            
            Assert.AreEqual(124, Converter.ConvertToInt(str));
        }

        [TestMethod]
        public void CheckNegotiveNumber()
        {
            string str = "-325";

            Assert.AreEqual(-325, Converter.ConvertToInt(str));
        }

        [TestMethod]
        public void CheckInvalidFormat()
        {
            string str = "fearea";
            
            Assert.AreEqual(1, Converter.ConvertToInt(str));
        }

        [TestMethod]
        public void CheckExitFromBound()
        {
            string str = "2147483649";
            Assert.AreEqual(2, Converter.ConvertToInt(str));
        }

        [TestMethod]
        public void CheckNullString()
        {
            string str = null;

            Assert.AreEqual(0, Converter.ConvertToInt(str));
        }
    }
}
