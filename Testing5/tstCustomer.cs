using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstCustomer
    {
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
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            aCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateAdded, TestData);
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
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Barker";
            //assign the data to the property
            aCustomer.CustomerLastName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerLastName, TestData);
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
        public void CustomerPhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "07123456789";
            //assign the data to the property
            aCustomer.CustomerPhone = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aCustomer.CustomerPhone, TestData);
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
        public void FindMethodOK()
        {
            //create an instsance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            Found = aCustomer.Find(CustomerID);
            //test tp see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = aCustomer.Find(CustomerID);
            //check the dataAdded property
            if (aCustomer.DateAdded != Convert.ToDateTime("23/12/2026"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

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
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerID != 123)
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
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerFirstName != "Lewis")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerLastName != "Barker")
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
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerEmail != "lewis@email.com")
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
            Int32 CustomerID = 21;
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
        public void TestCustomerPhoneFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerPhone != "123")
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
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.CustomerAddress != "12 Leicester Road")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search 
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 CustomerID = 21;
            //invoke the method 
            Found = aCustomer.Find(CustomerID);
            //check the house no property 
            if (aCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}