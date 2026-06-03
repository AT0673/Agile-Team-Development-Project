using ClassLibrary;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string CustomerFirstName = "Lewis";
        bool CustomerIsActive = true;
        string CustomerEmail = "lewis@email.com";
        string CustomerPassword = "Pa$$w0rd";
        DateTime CustomerDOB = Convert.ToDateTime("01/01/2000");
        string CustomerAddress = "12 Leicester Road";
        string DateAdded = DateTime.Now.Date.ToString();


        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(aCustomer);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property 
            aCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property
            aCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Lewis";
            //assign the data to the property
            aCustomer.CustomerFirstName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerIsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            bool TestData = true;
            //assign the data to the property
            aCustomer.CustomerIsActive = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerIsActive, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "lewis@example.com";
            //assign the data to the property
            aCustomer.CustomerEmail = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "password123";
            //assign the data to the property
            aCustomer.CustomerPassword = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            DateTime TestData = Convert.ToDateTime("01/01/2000");
            //assign the data to the property
            aCustomer.CustomerDOB = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "21b Some Street, Leicester";
            //assign the data to the property
            aCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerAddress, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instsance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            //test tp see if the result is true
            Assert.IsTrue(Found);
        }

        /******************VALID METHOD TEST******************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
            //check the house no property 
            if (aCustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
            //check the house no property 
            if (aCustomer.CustomerFirstName != "Joe")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIsActiveFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerIsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerEmail != "joebloggs@email.com")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerPassword != "Pa$$w0rd")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerDOB != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerAddress != "12 Long Street, Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        /********************CUSTOMER ID PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerIDNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = -1; //this should trigger an error
            //invoke the method 
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("The Customer ID number may not be less than 0 : ", Error);
        }

        [TestMethod]
        public void CustomerIDNoMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = 0; //this should be ok
            //invoke the method 
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = 1; //this should be ok 
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = 0; //this should be ok 
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = 0; //this should be ok 
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = 0; //this should be ok 
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int CustomerID = 0; //this should be ok 
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            Error = aCustomer.Valid(CustomerID, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        /********************CUSTOMER FIRST NAME PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = ""; //this should trigger an error
                                           //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "a"; //this should be ok
                                            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "aa"; //this should be ok
                                             //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(49, 'a'); //this should be ok
                                                                     //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(50, 'a'); //this should be ok
                                                                     //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(51, 'a'); //this should trigger an error
                                                                     //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(25, 'a'); //this should be ok
                                                                     //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a'); //this should trigger an error
                                                                      //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        /********************CUSTOMER IS ACTIVE PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerIsActiveFalse()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            bool CustomerIsActive = false; //this should be ok
            //invoke the method                               
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerIsActiveTrue()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            bool CustomerIsActive = true; //this should be ok
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        /********************CUSTOMER EMAIL PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = ""; //this should trigger an error
            //invoke the method                           
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = "a@a.com"; //this should be ok
                                              //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a'); //this should be ok
                                                             //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a'); //this should be ok
                                                             //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a'); //this should trigger an error
                                                             //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a'); //this should be ok
                                                             //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a'); //this should trigger an error
                                                              //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        /********************CUSTOMER PASSWORD PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerPasswordMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = ""; //this should trigger an error
                                          //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerPasswordMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = "a"; //this should be ok
                                           //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerPasswordMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(49, 'a'); //this should be ok
                                                                   //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(50, 'a'); //this should be ok
                                                                   //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(51, 'a'); //this should trigger an error
                                                                   //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerPasswordMid()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(25, 'a'); //this should be ok
                                                                   //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerPasswordExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerPassword = "";
            CustomerPassword = CustomerPassword.PadRight(500, 'a'); //this should trigger an error
                                                                    //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        /********************CUSTOMER DOB PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerDOBExtremeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, TestDate, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerDOBMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, TestDate, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerDOBMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, TestDate, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerDOBMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddDays(1);
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, TestDate, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, TestDate, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        /********************CUSTOMER ADDRESS PARAMETER METHOD TESTS******************/
        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = ""; //this should trigger an error
                                         //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "a"; //this should be ok
                                          //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a'); //this should be ok
                                                                 //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a'); //this should be ok
                                                                 //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(51, 'a'); //this should trigger an error
                                                                 //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(25, 'a'); //this should be ok
                                                                 //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a'); //this should trigger an error
                                                                  //invoke the method 
            Error = aCustomer.Valid(0, CustomerFirstName, CustomerIsActive, CustomerEmail, CustomerPassword, CustomerDOB, CustomerAddress);
            //test to see that the result is correct 
            Assert.AreNotEqual("", Error);
        }



    }
}