using Microsoft.SqlServer.Server;
using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierID;
        private DateTime dateCreated;
        private bool isActive;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;

        public int SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }
        public string SupplierName
        {
            get
            {
                return name;
            }
            set
            {
                 name = value;
            }
        }
            
        public string SupplierPhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public string SupplierAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public DateTime SupplierCreatedDate
        {
            get
            {
                return dateCreated;
            }
            set
            {
                dateCreated = value;
            }
        }
        public bool SupplierActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }

        public string SupplierEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public bool Find(int supplierID)
        {
            mSupplierID = 21;
            dateCreated = Convert.ToDateTime("23/12/2022");
            email = "supplier@gmail.com";
            name = "Test Name";
            isActive = true;
            address = "Test Street 123";
            phoneNumber = "123456789";
            return true;

        }
    }
}