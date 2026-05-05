using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStock AnStock = new clsStock();
            //test it exists
            Assert.IsNotNull(AnStock);
        }
    }
}
