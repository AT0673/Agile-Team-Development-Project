using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
           //private data member for the list
            List<clsStaff> mStaffList = new List<clsStaff>();

            public List<clsStaff> StaffList
            {
                get
                {
                    return mStaffList;
                }
                set
                {
                    mStaffList = value;
                }
            }

            //private member data for ThisStaff
            clsStaff mThisStaff = new clsStaff();

            public clsStaff ThisStaff
            {
                get
                {
                    return mThisStaff;
                }
                set
                {
                    mThisStaff = value;
                }
            }

            //count property
            public int Count
            {
                get
                {
                    return mStaffList.Count;
                }
                set
                {
                    //left blank intentionally
                }
            }

            //constructor
            public clsStaffCollection()
            {
                clsDataConnection DB = new clsDataConnection();

                //execute stored procedure
                DB.Execute("sproc_tblStaff_SelectAll");

                //populate list
                PopulateArray(DB);
            }

            //add method
            public int Add()
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
                DB.AddParameter("@StaffIsActive", mThisStaff.StaffIsActive);
                DB.AddParameter("@StaffUsername", mThisStaff.StaffUsername);
                DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
                DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
                DB.AddParameter("@DateAdded", mThisStaff.DateAdded);

                return DB.Execute("sproc_tblStaff_Insert");
            }

            //update method
            public void Update()
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@StaffID", mThisStaff.StaffID);
                DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
                DB.AddParameter("@StaffIsActive", mThisStaff.StaffIsActive);
                DB.AddParameter("@StaffUsername", mThisStaff.StaffUsername);
                DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
                DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
                DB.AddParameter("@DateAdded", mThisStaff.DateAdded);

                DB.Execute("sproc_tblStaff_Update");
            }

            //delete method
            public void Delete()
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@StaffID", mThisStaff.StaffID);

                DB.Execute("sproc_tblStaff_Delete");
            }

            //filter by surname
            public void ReportByStaffLastName(string StaffLastName)
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@StaffLastName", StaffLastName);

                DB.Execute("sproc_tblStaff_FilterByLastName");

                PopulateArray(DB);
            }

            //populate list from database
            private void PopulateArray(clsDataConnection DB)
            {
                Int32 Index = 0;
                Int32 RecordCount = DB.Count;

                mStaffList = new List<clsStaff>();

                while (Index < RecordCount)
                {
                    clsStaff AStaff = new clsStaff();

                    AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                    AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                    AStaff.StaffIsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffIsActive"]);
                    AStaff.StaffUsername = Convert.ToString(DB.DataTable.Rows[Index]["StaffUsername"]);
                    AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                    AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                    AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                    mStaffList.Add(AStaff);

                    Index++;

            }
        }
    }
}




