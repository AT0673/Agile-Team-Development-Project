using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            Assert.IsNotNull(aSupplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            Int32 TestData = 1;
            aSupplier.SupplierID = TestData;
            Assert.AreEqual(aSupplier.SupplierID, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "Test Supplier";
            aSupplier.SupplierName = TestData;
            Assert.AreEqual(aSupplier.SupplierName, TestData);

        }
        [TestMethod]
        public void SupplierEmailPropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "abcdef@email.com";
            aSupplier.SupplierEmail = TestData;
            Assert.AreEqual(aSupplier.SupplierEmail, TestData);
        }

        [TestMethod]
        public void SupplierPhoneNumberPropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "0123456789";
            aSupplier.SupplierPhoneNumber = TestData;
            Assert.AreEqual(aSupplier.SupplierPhoneNumber, TestData);
        }

        [TestMethod]
        public void SupplierAddressPropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "123 Test Street";
            aSupplier.SupplierAddress = TestData;
            Assert.AreEqual(aSupplier.SupplierAddress, TestData);
        }

        [TestMethod]
        public void SupplierCreatedDatePropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            aSupplier.SupplierCreatedDate = TestData;
            Assert.AreEqual(aSupplier.SupplierCreatedDate, TestData);
        }

        [TestMethod]
        public void SupplierActivePropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean TestData = true;
            aSupplier.SupplierActive = TestData;
            Assert.AreEqual(aSupplier.SupplierActive, TestData);
        }

    }
}
