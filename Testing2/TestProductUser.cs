using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProductUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            string TestData = "Josh";
            //assign the data to the property
            AnUser.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            string TestData = "PasswordNoob";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            String TestData = "Product";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            string Username = "Josh";
            string Password = "PasswordNoob";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestUsernamePWFound()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            Boolean OK = true;
            string Username = "Josh";
            string Password = "PasswordNoob";
            //invoke the method
            Found = AnUser.FindUser(Username, Password);
             if (AnUser.Username != Username && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
