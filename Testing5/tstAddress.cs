using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void InstanceOK()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAddress.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.DateAdded, TestData);
        }
        [TestMethod]
        public void AddressIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.AddressId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AddressId, TestData);
        }
        [TestMethod]
        public void CountyCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.CountyCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CountyCode, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            string TestData = "21b";
            //assign the data to the property 
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            string TestData = "LE1 4AB";
            //assign the data to the property 
            AnAddress.PostCode = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.PostCode, TestData);
        }
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            string TestData = "Some Street";
            //assign the data to the property 
            AnAddress.Street = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Street, TestData);
        }
        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            string TestData = "Leicester";
            //assign the data to the property 
            AnAddress.Town = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Town, TestData);
        }
    }
}