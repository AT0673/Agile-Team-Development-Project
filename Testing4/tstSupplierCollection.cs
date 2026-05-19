using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 5;
            TestItem.SupplierName = "Michael Jordan";
            TestItem.SupplierEmail = "michael.jordan@supplier.com";
            TestItem.SupplierAddress = "964 Garry Street";
            TestItem.SupplierPhoneNumber = "26816018680168016";
            TestItem.SupplierCreatedDate = DateTime.Now;
            TestList.Add(TestItem);
            AllSuppliers.Supplierlist = TestList;
            Assert.AreEqual(AllSuppliers.Supplierlist, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.SupplierActive = true;
            TestSupplier.SupplierID = 1;
            TestSupplier.SupplierPhoneNumber = "1234567890";
            TestSupplier.SupplierEmail = "test@supplier.com";
            TestSupplier.SupplierName = "Test Supplier";
            TestSupplier.SupplierCreatedDate = DateTime.Now;
            TestSupplier.SupplierAddress = "123 Test Street";
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;
            TestList.Add(TestItem);
            AllSuppliers.Supplierlist = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
    }
}
