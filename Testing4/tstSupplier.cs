using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{ 
    [TestClass]
    public class tstSupplier
    {

        string supplierName = "Michael Jordan";
        string supplierAddress = "964 Garry Street";
        string supplierEmail = "michael@outlook.com";
        string supplierPhoneNumber = "26816018680168016";
        DateTime supplierCreatedDate = DateTime.Now.Date;

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
            Int32 SupplierID = 5;
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
            if (aSupplier.SupplierActive != true)
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
            Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        // -----------------------Supplier Name Tests-----------------------

        [TestMethod]
        public void SupplierNameExtremeMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = "";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = "";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = "a";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = "aa";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = "abcdefghij";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = new string('a', 49);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = new string('a', 50);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = new string('a', 51);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierName = new string('a', 500);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        // -----------------------Supplier Address Tests-----------------------

        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "a";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "aa";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "123 Test Street";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = new string('a', 49);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = new string('a', 50);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = new string('a', 51);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = new string('a', 500);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        // -----------------------Supplier Email Tests-----------------------

        [TestMethod]
        public void SupplierEmailMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "a@a.com";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "ab@gmail.com";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "supplier@gmail.com";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = new string('a', 39) + "@gmail.com";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = new string('a', 40) + "@gmail.com";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = new string('a', 60) + "@gmail.com";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailInvalidFormat()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "invalidemail";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        // -----------------------Supplier Phone Number Tests-----------------------

        [TestMethod]
        public void SupplierPhoneNumberMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierPhoneNumber = "1";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierPhoneNumber = "12";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierPhoneNumber = "0123456789";

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierPhoneNumber = new string('1', 19);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierPhoneNumber = new string('1', 20);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string supplierPhoneNumber = new string('1', 21);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        // -----------------------Supplier Created Date Tests-----------------------

        [TestMethod]
        public void SupplierCreatedDateExtremeMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";

            DateTime supplierCreatedDate = DateTime.Now.Date.AddYears(-100);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateMinLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";

            DateTime supplierCreatedDate = DateTime.Now.Date.AddDays(-1);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";

            DateTime supplierCreatedDate = DateTime.Now.Date;

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";

            DateTime supplierCreatedDate = DateTime.Now.Date.AddDays(1);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";

            DateTime supplierCreatedDate = DateTime.Now.Date.AddYears(100);

            Error = aSupplier.Valid(supplierName, supplierAddress, supplierEmail,
                                    supplierPhoneNumber, supplierCreatedDate);

            Assert.AreNotEqual("", Error);
        }
    }

}