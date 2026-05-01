using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplier aSupplier = new clsSupplier();
            Assert.IsNotNull(aSupplier);
        }
    }
}
