using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class
            clsOrderUser AnUser = new clsOrderUser();
            //test to see it isnt null
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //Create an instance
            clsOrderUser AnUser = new clsOrderUser();
            //Create test data
            Int32 TestData = 1;
            //Assign it
            AnUser.UserID = TestData;
            //Test to see that theyre equal
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Dawn";
            //assign the data to the property
            AnUser.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Username, TestData);
        }
        
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Address Book";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance
            clsOrderUser AnUser = new clsOrderUser();
            //create a boolean variable
            Boolean Found = false;
            //Create test data
            string Username = "Alfie";
            string Password = "Password123";
            //Invoke the method
            Found = AnUser.FindUser(Username, Password);
            //Test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUsernamePWFound()
        {
            //create an instance
            clsOrderUser AnUser = new clsOrderUser();
            //create a boolean value to store the result
            Boolean Found = false;
            //Create boolean to assume data is found
            Boolean OK = true;
            //Create some test data
            string Username = "Alfie";
            string Password = "Password123";
            //invoke method
            Found = AnUser.FindUser(Username, Password);
            //check the userID property
            if (Found == false)
            {
                OK = false;
            }

            if (AnUser.Username != Username || AnUser.Password != Password)
            {
                OK = false;            
            }
            Assert.IsTrue(OK);

        }
    }
}
