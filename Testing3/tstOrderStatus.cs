using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrderStatus
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that it exists
            Assert.IsNotNull(OrderStatus);
        }

        [TestMethod]
        public void DefaultStatusOK()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that the default status is correct
            Assert.AreEqual("Pending", OrderStatus.DefaultStatus);
        }

        [TestMethod]
        public void AllStatusesOK()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that all expected statuses are available
            Assert.AreEqual(5, OrderStatus.AllStatuses.Length);
        }

        [TestMethod]
        public void PendingStatusValid()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that Pending is valid
            Assert.IsTrue(OrderStatus.IsValidStatus("Pending"));
        }

        [TestMethod]
        public void ProcessingStatusValid()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that Processing is valid
            Assert.IsTrue(OrderStatus.IsValidStatus("Processing"));
        }

        [TestMethod]
        public void InvalidStatusRejected()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that an unsupported status is invalid
            Assert.IsFalse(OrderStatus.IsValidStatus("Shipped"));
        }

        [TestMethod]
        public void BlankStatusRejected()
        {
            //create an instance of the class we want to create
            clsOrderStatus OrderStatus = new clsOrderStatus();
            //test to see that a blank status is invalid
            Assert.IsFalse(OrderStatus.IsValidStatus(""));
        }
    }
}
