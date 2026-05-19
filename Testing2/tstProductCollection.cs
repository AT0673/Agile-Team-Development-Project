using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstProductCollection
    {
        public object AllProducts { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsProductCollection AllStocks = new clsProductCollection();
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void ProductListOK()
        {
            clsProductCollection AllStocks = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();
            TestItem.ProductID = 1;
            TestItem.ProductName = "Test Product";
            TestItem.ProductAmount = 10;
            TestItem.SupplierID = 1;
            TestItem.InStock = true;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStocks.ProductList = TestList;
            Assert.AreEqual(AllStocks.ProductList, TestList);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            TestProduct.ProductID = 1;
            TestProduct.ProductName = "Test Product";
            TestProduct.ProductAmount = 10;
            TestProduct.SupplierID = 1;
            TestProduct.InStock = true;
            TestProduct.StockArrivalDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();
            TestItem.ProductID = 1;
            TestItem.ProductName = "Test Product";
            TestItem.ProductAmount = 10;
            TestItem.SupplierID = 1;
            TestItem.InStock = true;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllProducts.ProductList = TestList;
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 1;
            TestItem.ProductName = "Test Product";
            TestItem.ProductAmount = 10;
            TestItem.SupplierID = 1;
            TestItem.InStock = true;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();
            TestItem.ProductID = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);

        }
        public void UpdateMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();
            Int32 PrimaryKey = 0;
            TestItem.ProductID = 1;
            TestItem.ProductName = "Test Product";
            TestItem.ProductAmount = 10;
            TestItem.SupplierID = 1;
            TestItem.InStock = true;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            AllProducts.ThisProduct = TestItem;
            PrimaryKey = AllProducts.Add();
            TestItem.ProductID = PrimaryKey;
            TestItem.ProductName = "Updated Product";
            AllProducts.ThisProduct = TestItem;
            AllProducts.Update();
            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
    }
}
