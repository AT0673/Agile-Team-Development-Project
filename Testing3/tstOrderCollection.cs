using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void tstOrderCollectionExists()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 10.00m;
            TestItem.OrderStatus = "Processing";
            TestItem.isGuestOrder = false;
            TestItem.ProductID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalPrice = 10.00m;
            TestOrder.OrderStatus = "Processing";
            TestOrder.isGuestOrder = false;
            TestOrder.ProductID = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 10.00m;
            TestItem.OrderStatus = "Processing";
            TestItem.isGuestOrder = false;
            TestItem.ProductID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //Set Primary key to an initial value
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 10.00m;
            TestItem.OrderStatus = "Processing";
            TestItem.isGuestOrder = false;
            TestItem.ProductID = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //Set Primary key to an initial value
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 10.00m;
            TestItem.OrderStatus = "Processing";
            TestItem.isGuestOrder = false;
            TestItem.ProductID = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.OrderStatus = "Shipped";
            //assign the data to the property
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //Set Primary key to an initial value
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 10.00m;
            TestItem.OrderStatus = "Processing";
            TestItem.isGuestOrder = false;
            TestItem.ProductID = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByOrderStatusMethodOK()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply an order status that should exist in the test data
            FilteredOrders.ReportByOrderStatus("Pending");
            //test to see that filtered records were found
            Assert.AreNotEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderStatusNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a OrderStatus that doesn't exist
            FilteredOrders.ReportByOrderStatus("This is not a valid OrderStatus");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderStatusTestDataFound()
        {
            //Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply an OrderStatus known to be in the test data
            FilteredOrders.ReportByOrderStatus("Pending");

            if (FilteredOrders.Count > 0)
            {
                //check that every record has the expected status
                foreach (clsOrder AnOrder in FilteredOrders.OrderList)
                {
                    if (AnOrder.OrderStatus != "Pending")
                    {
                        OK = false;
                    }
                }
            }
            else
            {
                OK = false;
            }
            //test to see that only records with this status were returned
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReportByCustomerIDMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a customer id that should exist in the test data
            FilteredOrders.ReportByCustomerID(13);
            //test to see that filtered records were found
            Assert.AreNotEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerIDNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a customer id that should not exist
            FilteredOrders.ReportByCustomerID(999999);
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByCustomerIDTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply a customer id known to be in the test data
            FilteredOrders.ReportByCustomerID(13);

            if (FilteredOrders.Count > 0)
            {
                foreach (clsOrder AnOrder in FilteredOrders.OrderList)
                {
                    if (AnOrder.CustomerID != 13)
                    {
                        OK = false;
                    }
                }
            }
            else
            {
                OK = false;
            }

            //test to see that only records for this customer were returned
            Assert.IsTrue(OK);
        }
    }
}
