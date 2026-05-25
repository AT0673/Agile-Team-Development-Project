using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
       
            //good test data
            //create some test data to pass the method
            string StaffLastName = "Okagbue";
            bool StaffIsActive = true;
            string StaffUsername = "FabOk123";
            string StaffPassword = "!Tiger246";
            string StaffAddress = "48 Lord Street";
            string DateAdded = DateTime.Now.Date.ToString();


            [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }    
        
        [TestMethod]
        public void ActivePropertyOK()
        {
            // create an instance of the class we want to create
                clsStaff AStaff = new clsStaff();
           // create some test data to assign to the property
                Boolean TestData = true;
                // assign the data to the property
                AStaff.Active = TestData;
          // test to see that the two values are the same
                Assert.AreEqual(AStaff.Active, TestData);
        }

       [TestMethod]
        public void DateAddedPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AStaff.DateAdded = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            // create some test data to assign to the property
            int TestData = 1;
            // assign the data to the property
            aStaff.StaffID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(aStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "Okagbue";
            //assign the data to the property
            aStaff.StaffLastName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void StaffIsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property 
            bool TestData = true;
            //assign the data to the property
            aStaff.StaffIsActive = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aStaff.StaffIsActive, TestData);
        }

        [TestMethod]
        public void StaffUsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "FabOk123";
            //assign the data to the property
            aStaff.StaffUsername = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aStaff.StaffUsername, TestData);
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "!tiger246";
            //assign the data to the property
            aStaff.StaffPassword = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aStaff.StaffPassword, TestData);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "48 Lord Street, Leicester";
            //assign the data to the property
            aStaff.StaffAddress = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aStaff.StaffAddress, TestData);
        }

        //VALID METHOD TEST
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
           //invoke the method
            Error = AStaff.Valid(StaffLastName, StaffUsername, StaffPassword, StaffAddress, StaffIsActive, DateTime.Now.Date);
           //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //FIND METHOD TEST
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instsance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 21;
            Found = aStaff.Find(StaffID);
            //test tp see if the result is true
            Assert.IsTrue(Found);
        }










    }
}

