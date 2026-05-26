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
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            int TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Test User";
            AnUser.Username = TestData;
            Assert.AreEqual(AnUser.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "TestPassword";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Test Department";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            string Username = "Jay";
            string Password = "TestPassword";
            Found = AnUser.FindUser(Username, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "Jay";
            string Password = "TestPassword";
            Found = AnUser.FindUser(Username, Password);
            if (AnUser.Username != "Jay" || AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
