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
            //generate a random ID
            Random rnd = new Random();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = rnd.Next(100000, 999999);
            TestItem.CustomerEmail = "test@email.com";
            TestItem.CustomerFirstName = "Test Data";
            TestItem.CustomerIsActive = true;
            TestItem.CustomerPassword = "Pa$$w0rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "11 Test Road";
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
            //generate a random ID
            Random rnd = new Random();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = rnd.Next(100000, 999999);
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

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //generate a random ID
            Random rnd = new Random();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = rnd.Next(100000, 999999);
            TestItem.CustomerEmail = "lewis@email.com";
            TestItem.CustomerFirstName = "Lewis";
            TestItem.CustomerIsActive = true;
            TestItem.CustomerPassword = "Pa$$w0rd";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerAddress = "11 Leicester Road";
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerFirstNameMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByCustomerFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a first name that doesn't exist
            FilteredCustomers.ReportByCustomerFirstName("xxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply a first name that doesn't exist
            FilteredCustomers.ReportByCustomerFirstName("Joe");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 1)
            {
                //check that the first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
