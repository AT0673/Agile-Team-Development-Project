using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // check that an instance of clsSupplierUser can be created
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            // test the UserID property assignment and retrieval
            clsSupplierUser AnUser = new clsSupplierUser();
            int TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(TestData, AnUser.UserID);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            // test the Username property 
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Test User";
            AnUser.Username = TestData;
            Assert.AreEqual(TestData, AnUser.Username);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // test the Password property 
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "TestPassword";
            AnUser.Password = TestData;
            Assert.AreEqual(TestData, AnUser.Password);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // test the Department property
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Test Department";
            AnUser.Department = TestData;
            Assert.AreEqual(TestData, AnUser.Department);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            // ensure FindUser() returns true when valid credentials are supplied
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = AnUser.FindUser("Jay", "TestPassword");
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            // ensure FindUser() correctly sets Username and Password properties
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = AnUser.FindUser("Jay", "TestPassword");

            Boolean OK = true;

            // check Username matches expected value
            if (AnUser.Username != "Jay")
            {
                OK = false;
            }

            // check Password matches expected value
            if (AnUser.Password != "TestPassword")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
