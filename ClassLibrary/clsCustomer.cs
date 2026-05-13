using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary
{

    public class clsCustomer
    {


        //private data member for the address id property
        private Boolean mActive;
        //CustomerID public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateAdded;

        //dateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data oit of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the address id property
        private Int32 mCustomerID;
        //CustomerID public property
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for the address id property
        private string mCustomerFirstName;
        //CustomerID public property
        public string CustomerFirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFirstName = value;
            }
        }
        //private data member for the address id property
        private Boolean mCustomerIsActive;
        //CustomerID public property
        public bool CustomerIsActive
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerIsActive;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerIsActive = value;
            }
        }

        //private data member for the address id property
        private string mCustomerEmail;
        //CustomerID public property
        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        //private data member for the address id property
        private string mCustomerPassword;
        //CustomerID public property
        public string CustomerPassword
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPassword;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPassword = value;
            }
        }
        //private data member for the address id property
        private DateTime mCustomerDOB;
        //CustomerID public property
        public DateTime CustomerDOB
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerDOB;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerDOB = value;
            }
        }

        //private data member for the address id property
        private string mCustomerAddress;
        //CustomerID public property
        public string CustomerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerIsActive"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        /****** VALIDATION METHOD ******/

        public string Valid(int customerID, string customerFirstName, bool customerIsActive, string customerEmail, string customerPassword, DateTime customerDOB, string customerAddress, DateTime dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //if the ID is less than 1
            if (customerID < 0)
            {
                //record the error
                Error = Error + "The Customer ID number may not be less than 0 : ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            //check to see if the date is less than today's date
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date 
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error 
                Error = Error + "The date cannot be in the future : ";
            }
            //if the customer first name is blank
            if (customerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The customer first name may not be blank : ";
            }
            //if the customer first name is greater than 50 characters
            if (customerFirstName.Length > 50)
            {
                //record the error
                Error = Error + "The customer first name must be less than 50 characters : ";
            }
            //if the customer email is blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The customer email may not be blank : ";
            }
            //if the customer email is greater than 50 characters
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The customer email must be less than 50 characters : ";
            }
            //if the customer password is blank
            if (customerPassword.Length == 0)
            {
                //record the error
                Error = Error + "The customer password may not be blank : ";
            }
            //if the customer password is greater than 50 characters
            if (customerPassword.Length > 50)
            {
                //record the error
                Error = Error + "The customer password must be less than 50 characters : ";
            }
            //if the customer address is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The customer address may not be blank : ";
            }
            //if the customer address is greater than 50 characters
            if (customerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The customer address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }

        
    }
}
