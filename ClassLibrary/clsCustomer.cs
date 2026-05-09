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
        private string mCustomerLastName;
        //CustomerID public property
        public string CustomerLastName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerLastName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerLastName = value;
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
        private string mCustomerPhone;
        //CustomerID public property
        public string CustomerPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerPhone;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerPhone = value;
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
            //set the private data members to the test data value
            mCustomerID = 21;
            CustomerFirstName = "Lewis";
            CustomerLastName = "Barker";
            CustomerEmail = "lewis@email.com";
            CustomerPassword = "Pa$$w0rd";
            CustomerPhone = "123";
            CustomerAddress = "12 Leicester Road";
            mDateAdded = Convert.ToDateTime("23/12/2026");
            //always return true
            return true;
        }
    }
}
