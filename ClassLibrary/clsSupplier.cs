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
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                dateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierCreatedDate"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                name = Convert.ToString(DB.DataTable.Rows[0]["SupplerName"]);
                isActive = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierActive"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                phoneNumber = Convert.ToString(DB.DataTable.Rows[0]["SupplierPhoneNumber"]);
                return true;

            }
            else { return false; }
        }

        public string Valid(string supplierName, string supplierPhoneNumber, string supplierAddress, string supplierEmail, DateTime supplierCreatedDate)
        {
            return "";
        }
    }
}