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

        [TestMethod]

        public void FindMethodOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressIDFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        
       public void TestDateCreatedFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierCreatedDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierName != "Test Name") 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAddressFound()
        {

            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierAddress != "Test Street 123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {

            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierEmail != "supplier@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierPhoneNumberFound()
        {

            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierPhoneNumber != "123456789" )
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestSupplierActiveFound()
        {

            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierActive != true )
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
