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
        public void     StockArrivalDateOK()
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
    }
}