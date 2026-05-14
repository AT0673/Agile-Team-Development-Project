using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Diagnostics.Contracts;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        //Good Data
        string ProductName = "Test Product";
        string ProductAmount = "1";
        string StockArrivalDate = DateTime.Now.Date.ToString();
        string SupplierID = "1";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsProduct AnStock = new clsProduct();
            //test it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            clsProduct AnProduct = new clsProduct();

            int TestData = 0;

            AnProduct.ProductID = TestData;

            Assert.AreEqual(AnProduct.ProductID, TestData);
        }
        [TestMethod]

        public void ProductAmountOK()
        {
            clsProduct AnProduct = new clsProduct();

            int TestData = 0;

            AnProduct.ProductAmount = TestData;

            Assert.AreNotEqual(AnProduct.ProductAmount, 1);
        }

        [TestMethod]
        public void StockArrivalDateOK()
        {
            clsProduct AnProduct = new clsProduct();

            DateTime TestData = DateTime.Now;

            AnProduct.StockArrivalDate = TestData;

            Assert.AreEqual(AnProduct.StockArrivalDate, TestData);
        }

        [TestMethod]
        public void SupplierIDOK()
        {
            clsProduct AnProduct = new clsProduct();
            int TestData = 0;
            AnProduct.SupplierID = TestData;
            Assert.AreEqual(AnProduct.SupplierID, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            clsProduct AnProduct = new clsProduct();

            bool TestData = true;

            AnProduct.InStock = TestData;

            Assert.AreEqual(AnProduct.InStock, TestData);
        }

        [TestMethod]
        public void ProductnameOK()
        {
            clsProduct AnProduct = new clsProduct();

            string TestData = "Test Product";

            AnProduct.ProductName = TestData;

            Assert.AreEqual(AnProduct.ProductName, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.ProductID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductAmountFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.ProductAmount != 0)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockArrivalDateFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.StockArrivalDate != new DateTime(2026, 6, 1))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.SupplierID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.InStock != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 2;
            Found = AnProduct.Find(ProductID);
            if (AnProduct.ProductName.Trim() != "Product")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = "Test Product";
            String ProductAmount = "1";
            String StockArrivalDate = DateTime.Now.Date.ToString();
            String SupplierID = "1";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }

        /******* Boundary Testing for Product Name********/
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = "";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = "a";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = "aa";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = new string('a', 49);
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = new string('a', 50);
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = new string('a', 51);
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = new string('a', 25);
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = new string('a', 100);
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMin()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductName = new string('a', 0);
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }

        /******* Boundary Testing for Product Amount********/
        [TestMethod]
        public void ProductAmountMinLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "0";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountMin()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "1";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "2";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountMaxMinusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "2147483646";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "2147483647";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountMaxPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "2147483648";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "9999999999";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductAmountInvalidDataType()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String ProductAmount = "Test";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }

        /******* Boundary Testing for Stock Arrival Date********/
        [TestMethod]
        public void StockArrivalDateMinLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddDays(-31).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateMin()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddDays(-30).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddDays(-29).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateMaxMinusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddDays(29).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddDays(30).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateMaxPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddDays(31).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.AddYears(100).ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateMid()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = DateTime.Now.ToString();
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockArrivalDateInvalidDataType()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String StockArrivalDate = "Test";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }

        /******* Boundary Testing for Supplier ID********/
        [TestMethod]
        public void SupplierIDMinLessOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "0";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMin()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "1";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMinPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "2";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMaxMinusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "2147483646";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "2147483647";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMaxPlusOne()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "2147483648";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDMid()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "1073741823";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDExtremeMax()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "9999999999";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierIDInvalidDataType()
        {
            clsProduct AnProduct = new clsProduct();
            String Error = "";
            String SupplierID = "Test";
            Error = AnProduct.Valid(ProductName, ProductAmount, StockArrivalDate, SupplierID);
            Assert.AreNotEqual(Error, "");
        }
    }
}
