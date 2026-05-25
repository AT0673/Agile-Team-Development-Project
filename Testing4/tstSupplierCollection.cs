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

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;
            AllSuppliers.ThisSupplier = TestItem;
            int PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            TestItem.SupplierActive = false;
            TestItem.SupplierName = "Updated Supplier";
            TestItem.SupplierEmail = "updated@supplier.com";
            TestItem.SupplierAddress = "456 Updated Street";
            TestItem.SupplierPhoneNumber = "0987654321";
            TestItem.SupplierCreatedDate = DateTime.Now;
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierID = PrimaryKey;
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Delete();
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportBySupplierNameMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("xxx xxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportbySupplierNameFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySupplierName("Test Supplier");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.Supplierlist[0].SupplierID != 1)
                {
                    OK = false;
                }
                if (FilteredSuppliers.Supplierlist[1].SupplierID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
