using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerEmail = "lewis@email.com";
            TestItem.CustomerFirstName = "Lewis";
            TestItem.CustomerIsActive = true;
            TestItem.CustomerPassword = "Pa$$w0rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "11 Leicester Road";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.CustomerEmail = "lewis@email.com";
            TestCustomer.CustomerFirstName = "Lewis";
            TestCustomer.CustomerIsActive = true;
            TestCustomer.CustomerPassword = "Pa$$w0rd";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.CustomerAddress = "11 Leicester Road";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerEmail = "lewis@email.com";
            TestItem.CustomerFirstName = "Lewis";
            TestItem.CustomerIsActive = true;
            TestItem.CustomerPassword = "Pa$$w0rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "11 Leicester Road";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the count is correct
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerEmail = "lewis@email.com";
            TestItem.CustomerFirstName = "Lewis";
            TestItem.CustomerIsActive = true;
            TestItem.CustomerPassword = "Pa$$w0rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "11 Leicester Road";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerEmail = "lewis@email.com";
            TestItem.CustomerFirstName = "Lewis";
            TestItem.CustomerIsActive = true;
            TestItem.CustomerPassword = "Pa$$w0rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "11 Leicester Road";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerID = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerEmail = "mickeymouse@email.com";
            TestItem.CustomerFirstName = "Mickey";
            TestItem.CustomerIsActive = false;
            TestItem.CustomerPassword = "Password";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "13 Disney Road";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

    }
}
