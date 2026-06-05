using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestClass]
            public class tstStaffCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();
                Assert.IsNotNull(AllStaff);
            }

            [TestMethod]
            public void StaffListOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();

                List<clsStaff> TestList = new List<clsStaff>();

                clsStaff TestItem = new clsStaff();

                TestItem.Active = true;
                TestItem.StaffID = 1;
                TestItem.StaffUsername = "Fabok15";
                TestItem.StaffLastName = "Okagbue";
                TestItem.StaffPassword = "Pa$$w0rd";
                TestItem.StaffDOB = DateTime.Now.Date;
                TestItem.StaffAddress = "19 James street";

                TestList.Add(TestItem);

                AllStaff.StaffList = TestList;

                Assert.AreEqual(AllStaff.StaffList, TestList);
            }

            [TestMethod]
            public void ThisStaffPropertyOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();

                clsStaff TestStaff = new clsStaff();

                TestStaff.Active = true;
                TestStaff.StaffID = 1;
                TestStaff.StaffUsername = "Fabo13";
                TestStaff.StaffLastName = "Okagbue";
                TestStaff.StaffPassword = "Pa$$w0rd";
                TestStaff.StaffDOB = DateTime.Now.Date;
                TestStaff.StaffAddress = "42 Lord Street";

                AllStaff.ThisStaff = TestStaff;

                Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
            }

            [TestMethod]
            public void ListAndCountOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();

                List<clsStaff> TestList = new List<clsStaff>();

                clsStaff TestItem = new clsStaff();

                TestItem.Active = true;
                TestItem.StaffID = 1;
                TestItem.StaffUsername = "agent123";
                TestItem.StaffLastName = "Okagbue";
                TestItem.StaffPassword = "Pa$$w0rd";
                TestItem.StaffDOB = DateTime.Now.Date;
                TestItem.StaffAddress = "15 Muni Road";

                TestList.Add(TestItem);

                AllStaff.StaffList = TestList;

                Assert.AreEqual(AllStaff.Count, TestList.Count);
            }

            [TestMethod]
            public void AddMethodOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();

                clsStaff TestItem = new clsStaff();

                Int32 PrimaryKey = 0;

                Random rnd = new Random();

                TestItem.Active = true;
                TestItem.StaffID = rnd.Next(100000, 999999);
                TestItem.StaffUsername = "testuser";
                TestItem.StaffLastName = "Test";
                TestItem.StaffPassword = "Pa$$w0rd";
                TestItem.StaffDOB = DateTime.Now.Date;
                TestItem.StaffAddress = "42 Lord Road";

                AllStaff.ThisStaff = TestItem;

                PrimaryKey = AllStaff.Add();

                TestItem.StaffID = PrimaryKey;

                AllStaff.ThisStaff.Find(PrimaryKey);

                Assert.AreEqual(AllStaff.ThisStaff, TestItem);
            }

            [TestMethod]
            public void UpdateMethodOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();

                clsStaff TestItem = new clsStaff();

                Int32 PrimaryKey = 0;

                Random rnd = new Random();

                TestItem.Active = true;
                TestItem.StaffID = rnd.Next(100000, 999999);
                TestItem.StaffUsername = "fabok123";
                TestItem.StaffLastName = "Okagbue";
                TestItem.StaffPassword = "Pa$$w0rd";
                TestItem.StaffDOB = DateTime.Now.Date;
                TestItem.StaffAddress = "11 Peacock Road";

                AllStaff.ThisStaff = TestItem;

                PrimaryKey = AllStaff.Add();

                TestItem.StaffID = PrimaryKey;

                TestItem.Active = false;
                TestItem.StaffID = 2;
                TestItem.StaffUsername = "mickeymouse";
                TestItem.StaffLastName = "Mouse";
                TestItem.StaffPassword = "Password";
                TestItem.StaffDOB = DateTime.Now.Date;
                TestItem.StaffAddress = "41 Disney Road";

                AllStaff.ThisStaff = TestItem;

                AllStaff.Update();

                AllStaff.ThisStaff.Find(PrimaryKey);

                Assert.AreEqual(AllStaff.ThisStaff, TestItem);
            }

            [TestMethod]
            public void DeleteMethodOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();

                clsStaff TestItem = new clsStaff();

                Int32 PrimaryKey = 0;

                Random rnd = new Random();

                TestItem.Active = true;
                TestItem.StaffID = rnd.Next(100000, 999999);
                TestItem.StaffUsername = "lewis123";
                TestItem.StaffLastName = "Jones";
                TestItem.StaffPassword = "Pa$$w0rd";
                TestItem.StaffDOB = DateTime.Now.Date;
                TestItem.StaffAddress = "42 Lord Street";

                AllStaff.ThisStaff = TestItem;

                PrimaryKey = AllStaff.Add();

                TestItem.StaffID = PrimaryKey;

                AllStaff.ThisStaff.Find(PrimaryKey);

                AllStaff.Delete();

                Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

                Assert.IsFalse(Found);
            }

            [TestMethod]
            public void ReportByStaffLastNameMethodOK()
            {
                clsStaffCollection AllStaff = new clsStaffCollection();
                clsStaffCollection FilteredStaff = new clsStaffCollection();

                FilteredStaff.ReportByStaffLastName("");

                Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
            }

            [TestMethod]
            public void ReportByStaffLastNameNoneFound()
            {
                clsStaffCollection FilteredStaff = new clsStaffCollection();

                FilteredStaff.ReportByStaffLastName("xxxxxxx");

                Assert.AreEqual(0, FilteredStaff.Count);
            }

            [TestMethod]
            public void ReportByStaffLastNameTestDataFound()
            {
                clsStaffCollection FilteredStaff = new clsStaffCollection();

                Boolean OK = true;

                FilteredStaff.ReportByStaffLastName("Okagbue");

                if (FilteredStaff.Count == 1)
                {
                    if (FilteredStaff.StaffList[0].StaffID != 1)
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
    }
}
