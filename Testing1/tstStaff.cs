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
            string StaffDOB = Convert.ToDateTime("01/01/2000");
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
        public void StaffDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //create some test data to assign to the property 
            DateTime TestData = Convert.ToDateTime("19/05/1999");
            //assign the data to the property
            aStaff.StaffDOB = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aStaff.StaffDOB, TestData);
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
            Error = AStaff.Valid(StaffLastName, StaffUsername, StaffPassword, StaffAddress, StaffIsActive, StaffDOB);
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

        //PROPERTY DATA TESTS
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);
            Assert.IsTrue(Found);

            if (aStaff.StaffID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);
            Assert.IsTrue(Found);

            if (aStaff.StaffLastName != "Okagbue")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);

            if (aStaff.IsActive != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);

            if (aStaff.StaffEmail != "okagbue@test.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);

            if (aStaff.StaffPassword != "!Password246")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);

            if (aStaff.Date != Convert.ToDateTime("25/08/2025"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;

            Found = aStaff.Find(StaffID);

            if (aStaff.StaffAddress != "42 Lord Street")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


      //STAFF ID PARAMETER TEST
        [TestMethod]
        public void StaffIDNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = -1; 

            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("The Staff ID number may not be less than 0 : ", Error);
        }

        [TestMethod]
        public void StaffIDNoMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = 0; 

            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = 1; 

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = 0; 

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = 0; 

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = 0; 

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffID = 0; 

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            Error = aStaff.Valid(StaffID, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //STAFF LASTNAME PARAMETER TEST
        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "";

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "a";

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "aa";

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(49, 'a');

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(50, 'a');

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(51, 'a');

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(25, 'a');

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(500, 'a');

            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreNotEqual("", Error);
        }

        
        //STAFF IS ACTIVE PARAMETER TEST
        [TestMethod]
        public void IsActiveFalse()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            bool IsActive = false; //this should be ok
                                   //invoke the method
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void IsActiveTrue()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            bool IsActive = true; //this should be ok
                                  //invoke the method
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

         
        //STAFF USERNAME PARAMETER TEST
        [TestMethod]
        public void StaffUsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = ""; 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffUsernameMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = "!Sam123"; 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffUsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = "";
            StaffEmail = StaffUsername.PadRight(49, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffUsernameMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = "";
            StaffUsername = StaffUsername.PadRight(50, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffUsernameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = "";
            StaffUsername = StaffUsername.PadRight(51, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffUsernameMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = "";
            StaffUsername = StaffUsername.PadRight(25, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffUsernameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffUsername = "";
            StaffUsername = StaffUsername.PadRight(500, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

      
        //STAFF PASSWORD PARAMETER TEST
        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = ""; 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "a"; //this should be ok
                                        //invoke the method
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(49, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(50, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(51, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(25, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(500, 'a'); 
            Error = aStaff.Valid(0, StaffLastName, IsActive, StaffUsername, StaffPassword, StaffDOB, StaffAddress);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

     
        //STAFF ADDRESS PARAMETER TEST
        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "";

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "a";

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(49, 'a');

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(50, 'a');

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(51, 'a');

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(25, 'a');

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(500, 'a');

            Error = aStaff.Valid(0, StaffLastName, StaffIsActive, StaffEmail, StaffPassword, StaffDOB, StaffAddress);

            Assert.AreNotEqual("", Error);
        }

       
        //STAFF DOB PARAMETER TEST
        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);

            Error = aStaff.Valid(0, StaffFirstName, StaffIsActive, StaffEmail, StaffPassword, TestDate, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);

            Error = aStaff.Valid(0, StaffFirstName, StaffIsActive, StaffEmail, StaffPassword, TestDate, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            Error = aStaff.Valid(0, StaffFirstName, StaffIsActive, StaffEmail, StaffPassword, TestDate, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);

            Error = aStaff.Valid(0, StaffFirstName, StaffIsActive, StaffEmail, StaffPassword, TestDate, StaffAddress);

            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);

            Error = aStaff.Valid(0, StaffFirstName, StaffIsActive, StaffEmail, StaffPassword, TestDate, StaffAddress);

            Assert.AreEqual("", Error);
        }

    }
}

