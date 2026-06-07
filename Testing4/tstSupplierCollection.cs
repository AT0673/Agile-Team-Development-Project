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
            // ensure an instance of clsSupplierCollection can be created
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            // create a supplier collection and a test list
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();

            // create a test supplier object
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 5;
            TestItem.SupplierName = "Michael Jordan";
            TestItem.SupplierEmail = "michael.jordan@supplier.com";
            TestItem.SupplierAddress = "964 Garry Street";
            TestItem.SupplierPhoneNumber = "26816018680168016";
            TestItem.SupplierCreatedDate = DateTime.Now;

            // add to list and assign to collection
            TestList.Add(TestItem);
            AllSuppliers.Supplierlist = TestList;

            // check both lists match
            Assert.AreEqual(AllSuppliers.Supplierlist, TestList);
        }

  

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            // create collection and test supplier
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();

            // populate test supplier
            TestSupplier.SupplierActive = true;
            TestSupplier.SupplierID = 1;
            TestSupplier.SupplierPhoneNumber = "1234567890";
            TestSupplier.SupplierEmail = "test@supplier.com";
            TestSupplier.SupplierName = "Test Supplier";
            TestSupplier.SupplierCreatedDate = DateTime.Now;
            TestSupplier.SupplierAddress = "123 Test Street";

            // assign to collection
            AllSuppliers.ThisSupplier = TestSupplier;

            // check assignment
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        // ----------------------- List & Count Test -----------------------

        [TestMethod]
        public void ListAndCountOK()
        {
            // create collection and test list
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();

            // create test supplier
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;

            // add to list and assign
            TestList.Add(TestItem);
            AllSuppliers.Supplierlist = TestList;

            // count should match
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        // ----------------------- Add Method Test -----------------------

        [TestMethod]
        public void AddMethodOK()
        {
            // create collection and test supplier
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();

            // populate test supplier
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;

            // assign to collection
            AllSuppliers.ThisSupplier = TestItem;

            // add to database and retrieve primary key
            int PrimaryKey = AllSuppliers.Add();

            // update test item with new primary key
            TestItem.SupplierID = PrimaryKey;

            // find the record again
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            // compare the two objects
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;

            // Initial supplier data
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;

            // Add record
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();

            // Update primary key
            TestItem.SupplierID = PrimaryKey;

            // Modify supplier data
            TestItem.SupplierActive = false;
            TestItem.SupplierName = "Updated Supplier";
            TestItem.SupplierEmail = "updated@supplier.com";
            TestItem.SupplierAddress = "456 Updated Street";
            TestItem.SupplierPhoneNumber = "0987654321";
            TestItem.SupplierCreatedDate = DateTime.Now;

            // Update record
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();

            // Find updated record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);

            // Compare updated values
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        // ----------------------- Delete Method Test -----------------------

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;

            // Populate supplier
            TestItem.SupplierActive = true;
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Test Supplier";
            TestItem.SupplierEmail = "test@supplier.com";
            TestItem.SupplierAddress = "123 Test Street";
            TestItem.SupplierPhoneNumber = "1234567890";
            TestItem.SupplierCreatedDate = DateTime.Now;

            // Add record
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();

            // Set primary key
            TestItem.SupplierID = PrimaryKey;

            // Delete record
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Delete();

            // Attempt to find deleted record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);

            // Should not be found
            Assert.IsFalse(Found);
        }

        // ----------------------- ReportBySupplierName Tests -----------------------

        [TestMethod]
        public void ReportBySupplierNameMethodOK()
        {
            // Create two collections
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            // Apply blank filter (should return all records)
            FilteredSuppliers.ReportBySupplierName("");

            // Counts should match
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {
            // Apply filter that should return no results
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("xxx xxx");

            // Expect 0 results
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportbySupplierNameFound()
        {
            // Apply filter expected to return two specific records
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;

            FilteredSuppliers.ReportBySupplierName("Same Supplier");

            // Expect exactly two results
            if (FilteredSuppliers.Count == 2)
            {
                // Check first record ID
                if (FilteredSuppliers.Supplierlist[0].SupplierID != 47)
                {
                    OK = false;
                }

                // Check second record ID
                if (FilteredSuppliers.Supplierlist[1].SupplierID != 48)
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
