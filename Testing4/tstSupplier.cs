using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    string SupplierName = "Michael Jordan";
    string SupplierAddress = "964 Garry Street";
    string SupplierEmail = "michael@outlook.com";
    string SupplierPhoneNumber = "26816018680168016";
    DateTime SupplierCreatedDate = Convert.ToDateTime("24/04/2023");

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
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressIDFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierID != 5)
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
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierCreatedDate != Convert.ToDateTime("24/04/2023"))
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
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierName != "Michael Jordan") 
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
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierAddress != "964 Garry Street")
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
            if (aSupplier.SupplierEmail != "michael@outlook.com")
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
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierPhoneNumber != "26816018680168016")
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
            Int32 SupplierID = 5;
            Found = aSupplier.Find(SupplierID);
            if (aSupplier.SupplierActive != true )
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            Error = aSupplier.Valid(SupplierName, SupplierAddress, SupplierEmail, SupplierPhoneNumber, SupplierCreatedDate.ToString(), SupplierActive.ToString());
            Assert.AreEqual(Error, "");


        }
}
