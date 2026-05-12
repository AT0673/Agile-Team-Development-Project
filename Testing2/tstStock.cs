using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
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
    }
}