using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        // Reusable test data for validation tests
        string supplierName = "Michael Jordan";
        string supplierEmail = "michael@outlook.com";
        string supplierAddress = "964 Garry Street";
        string supplierPhoneNumber = "26816018680168016";
        DateTime supplierCreatedDate = DateTime.Now.Date;

        [TestMethod]
        public void InstanceOK()
        {
            // ensure an instance of clsSupplier can be created
            clsSupplier aSupplier = new clsSupplier();
            Assert.IsNotNull(aSupplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // test SupplierID property 
            clsSupplier aSupplier = new clsSupplier();
            Int32 TestData = 1;
            aSupplier.SupplierID = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierID);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            // test SupplierName property
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "Test Supplier";
            aSupplier.SupplierName = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierName);
        }

        [TestMethod]
        public void SupplierEmailPropertyOK()
        {
            // test SupplierEmail property 
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "abcdef@email.com";
            aSupplier.SupplierEmail = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierEmail);
        }

        [TestMethod]
        public void SupplierPhoneNumberPropertyOK()
        {
            // test SupplierPhoneNumber property
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "0123456789";
            aSupplier.SupplierPhoneNumber = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierPhoneNumber);
        }

        [TestMethod]
        public void SupplierAddressPropertyOK()
        {
            // test SupplierAddress property 
            clsSupplier aSupplier = new clsSupplier();
            string TestData = "123 Test Street";
            aSupplier.SupplierAddress = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierAddress);
        }

        [TestMethod]
        public void SupplierCreatedDatePropertyOK()
        {
            // test SupplierCreatedDate property
            clsSupplier aSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            aSupplier.SupplierCreatedDate = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierCreatedDate);
        }

        [TestMethod]
        public void SupplierActivePropertyOK()
        {
            // test SupplierActive property
            clsSupplier aSupplier = new clsSupplier();
            Boolean TestData = true;
            aSupplier.SupplierActive = TestData;
            Assert.AreEqual(TestData, aSupplier.SupplierActive);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Ensure Find() returns true for a valid SupplierID
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = aSupplier.Find(5);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressIDFound()
        {
            // Ensure Find() sets SupplierID correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.AreEqual(5, aSupplier.SupplierID);
        }

        [TestMethod]
        public void TestDateCreatedFound()
        {
            // Ensure Find() sets SupplierCreatedDate correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.AreEqual(Convert.ToDateTime("24/04/2023"), aSupplier.SupplierCreatedDate);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            // Ensure Find() sets SupplierName correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.AreEqual("Michael Jordan", aSupplier.SupplierName);
        }

        [TestMethod]
        public void TestSupplierAddressFound()
        {
            // Ensure Find() sets SupplierAddress correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.AreEqual("964 Garry Street", aSupplier.SupplierAddress);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            // Ensure Find() sets SupplierEmail correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.AreEqual("michael@outlook.com", aSupplier.SupplierEmail);
        }

        [TestMethod]
        public void TestSupplierPhoneNumberFound()
        {
            // Ensure Find() sets SupplierPhoneNumber correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.AreEqual("26816018680168016", aSupplier.SupplierPhoneNumber);
        }

        [TestMethod]
        public void TestSupplierActiveFound()
        {
            // Ensure Find() sets SupplierActive correctly
            clsSupplier aSupplier = new clsSupplier();
            aSupplier.Find(5);
            Assert.IsTrue(aSupplier.SupplierActive);
        }

        // ----------------------- Valid Method Test -----------------------

        [TestMethod]
        public void ValidMethodOK()
        {
            // Ensure Valid() returns no error for correct data
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(
                supplierName,
                supplierEmail,
                supplierAddress,
                supplierPhoneNumber,
                supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        // ----------------------- Supplier Name Validation Tests -----------------------

        [TestMethod]
        public void SupplierNameExtremeMin()
        {
            // Empty name should fail
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid("", supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            // Below minimum length
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid("", supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            // Minimum valid length (1 char)
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid("a", supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            // 2 chars
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid("aa", supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            // Mid‑range value
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid("Supplier Name", supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            // 49 chars
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(new string('a', 49), supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            // 50 chars
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(new string('a', 50), supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            // 51 chars should fail
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(new string('a', 51), supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            // 500 chars should fail
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(new string('a', 500), supplierEmail, supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        // ----------------------- Supplier Address Validation Tests -----------------------

        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, "a", supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, "aa", supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, "123 Test Street", supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, new string('a', 49), supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, new string('a', 50), supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, new string('a', 51), supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, new string('a', 500), supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        // ----------------------- Supplier Email Validation Tests -----------------------

        [TestMethod]
        public void SupplierEmailMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, "a@a.com", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, "ab@gmail.com", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, "supplier@gmail.com", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, new string('a', 39) + "@gmail.com", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, new string('a', 40) + "@gmail.com", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, new string('a', 41) + "@gmail.com", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, new string('@', 500), supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierEmailInvalidFormat()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, "invalidemail", supplierAddress, supplierPhoneNumber, supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        // ----------------------- Supplier Phone Number Validation Tests -----------------------

        [TestMethod]
        public void SupplierPhoneNumberMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, "1", supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, "12", supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, "0123456789", supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, new string('1', 19), supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, new string('1', 20), supplierCreatedDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, new string('1', 21), supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, new string('1', 500), supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierPhoneNumberInvalidFormat()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, "invalidphone", supplierCreatedDate);
            Assert.AreNotEqual("", Error);
        }

        // ----------------------- Supplier Created Date Validation Tests -----------------------

        [TestMethod]
        public void SupplierCreatedDateExtremeMin()
        {
            // Very old date — still valid
            clsSupplier aSupplier = new clsSupplier();
            DateTime testDate = DateTime.Now.Date.AddYears(-100);
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, supplierPhoneNumber, testDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateMinLessOne()
        {
            // Yesterday — valid
            clsSupplier aSupplier = new clsSupplier();
            DateTime testDate = DateTime.Now.Date.AddDays(-1);
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, supplierPhoneNumber, testDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateMin()
        {
            // Today — valid
            clsSupplier aSupplier = new clsSupplier();
            DateTime testDate = DateTime.Now.Date;
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, supplierPhoneNumber, testDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateMinPlusOne()
        {
            // Tomorrow — invalid
            clsSupplier aSupplier = new clsSupplier();
            DateTime testDate = DateTime.Now.Date.AddDays(1);
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, supplierPhoneNumber, testDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void SupplierCreatedDateExtremeMax()
        {
            // Far future — invalid
            clsSupplier aSupplier = new clsSupplier();
            DateTime testDate = DateTime.Now.Date.AddYears(100);
            String Error = aSupplier.Valid(supplierName, supplierEmail, supplierAddress, supplierPhoneNumber, testDate);
            Assert.AreNotEqual("", Error);
        }
    }
}
