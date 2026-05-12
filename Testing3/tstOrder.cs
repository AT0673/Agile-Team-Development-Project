using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {

        /********************************** Declaring some test data **********************************/
        string OrderID = "1";
        string CustomerID = "1";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalPrice = "10.00";
        string OrderStatus = "Pending";
        string isGuestOrder = "false";
        string ProductID = "1";
        /********************************** Instance of the class **********************************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        /********************************** Testing the properties **********************************/
        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalPriceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = 10.00m;
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void StatusOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Pending";
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void isGuestOrderOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnOrder.isGuestOrder = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.isGuestOrder, TestData);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }
        /*********************************** Testing the Find method **********************************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        /*********************************** Property Data Tests **********************************/
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 4;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.OrderID != 4)
            {
                Found = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 4;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the customer id
            if (AnOrder.CustomerID != 13)
            {
                Found = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 4;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the OrderDate property
            if (AnOrder.OrderDate != Convert.ToDateTime("07/05/2026"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 4;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the TotalPrice property
            if (AnOrder.TotalPrice != 20.00m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 4;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the Status property
            if (AnOrder.OrderStatus != "Pending")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 4;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the ProductID property
            if (AnOrder.ProductID != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestisGuestOrderFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean to assume the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the isGuestOrder property
            if (AnOrder.isGuestOrder != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        /*********************************** Testing the Valid method **********************************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*** Testing the CustomerID property of the Valid method ***/
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "0";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "1";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "2";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "2147483646";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "2147483647";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "2147483648";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "1073741823";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "9999999999";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /***** Testing the OrderDate property of the Valid method *****/
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //Create a variable to hold the test date data
            DateTime TestDate;
            //Set the test date to todays date
            TestDate = DateTime.Now.Date;
            //Set data to whatever the date was 100 years ago (should be invalid)
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //Create a variable to hold the test date data
            DateTime TestDate;
            //Set the test date to todays date
            TestDate = DateTime.Now.Date;
            //Set data to whatever the date was 1 day ago (should be invalid)
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //Create a variable to hold the test date data
            DateTime TestDate;
            //Set the test date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //Create a variable to hold the test date data
            DateTime TestDate;
            //Set the test date to todays date
            TestDate = DateTime.Now.Date;
            //Set data to whatever the date is 1 day in the future (should be valid)
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //Create a variable to hold the test date data
            DateTime TestDate;
            //Set the test date to todays date
            TestDate = DateTime.Now.Date;
            //Set data to whatever the date is 50 years in the future (should be valid)
            TestDate = TestDate.AddYears(50);
            //Convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); //Should be valid as it's within the acceptable range
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderDate = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*** Testing the TotalPrice property of the Valid method ***/
        [TestMethod]
        public void TotalPriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "-1000000.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "0.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "0.01";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "0.02";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "9999999.98";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "9999999";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "10000000.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "5000000.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "1000000000.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "This is not a price!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /******* Testing the OrderStatus property of the Valid method ***/
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "P";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = "Pe";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = new string('A', 49);
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = new string('A', 50);
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = new string('A', 51);
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = new string('A', 25);
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderStatus = new string('A', 500);
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /***** Testing the PropertyID property of the Valid method ***/

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "0";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "1";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "2";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "2147483646";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "2147483647";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "2147483648";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "1073741823";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "9999999999";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, TotalPrice, OrderStatus, isGuestOrder, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}