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

        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");

            if (DB.Count == 1)
            {
                mSupplierID   = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                dateCreated   = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedDate"]);
                email         = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
                name          = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]); 
                isActive      = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                address       = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                phoneNumber   = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);
                return true;

            }
            else { return false; }
        }

        public string Valid(string supplierName,
                    string supplierEmail,
                    string supplierAddress,
                    string supplierPhoneNumber,
                    DateTime supplierCreatedDate)
        {
            // create error variable
            String Error = "";

            // ---------------- Supplier Name Validation ----------------

            if (supplierName.Length == 0)
            {
                Error = Error + "Supplier name cannot be blank : ";
            }

            if (supplierName.Length > 50)
            {
                Error = Error + "Supplier name must be less than 50 characters : ";
            }

            // ---------------- Supplier Address Validation ----------------

            if (supplierAddress.Length == 0)
            {
                Error = Error + "Supplier address cannot be blank : ";
            }

            if (supplierAddress.Length > 50)
            {
                Error = Error + "Supplier address must be less than 50 characters : ";
            }

            // ---------------- Supplier Email Validation ----------------

            if (supplierEmail.Length == 0)
            {
                Error = Error + "Supplier email cannot be blank : ";
            }

            if (supplierEmail.Length > 50)
            {
                Error = Error + "Supplier email must be less than 50 characters : ";
            }

            if (!supplierEmail.Contains("@"))
            {
                Error = Error + "Email must contain @ : ";
            }

            // ---------------- Supplier Phone Number Validation ----------------

            if (supplierPhoneNumber.Length == 0)
            {
                Error = Error + "Phone number cannot be blank : ";
            }

            if (supplierPhoneNumber.Length > 20)
            {
                Error = Error + "Phone number must be less than 20 characters : ";
            }

            // ---------------- Supplier Created Date Validation ----------------

            if (supplierCreatedDate < DateTime.Now.Date)
            {
                Error = Error + "Date cannot be in the past : ";
            }

            if (supplierCreatedDate > DateTime.Now.Date)
            {
                Error = Error + "Date cannot be in the future : ";
            }

            // return any error messages
            return Error;
        }

    }
}