using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerIsActive", mThisCustomer.CustomerIsActive);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerIsActive", mThisCustomer.CustomerIsActive);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by tblCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                ACustomer.CustomerIsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerIsActive"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
            
        }
    }
}