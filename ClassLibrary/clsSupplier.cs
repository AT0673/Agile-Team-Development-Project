using Microsoft.SqlServer.Server;
using System;
using System.Linq;

namespace ClassLibrary
{
    public class clsSupplier
    {
        // private fields that store the actual supplier data
        private Int32 mSupplierID;
        private DateTime dateCreated;
        private bool isActive;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;

        // public properties

        public int SupplierID
        {
            get { return mSupplierID; }
            set { mSupplierID = value; }
        }

        public string SupplierName
        {
            get { return name; }
            set { name = value; }
        }

        public string SupplierPhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string SupplierAddress
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime SupplierCreatedDate
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public bool SupplierActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string SupplierEmail
        {
            get { return email; }
            set { email = value; }
        }

        // find method: looks up a supplier by ID and loads the data into this object
        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();

            // pass the ID into the stored procedure
            DB.AddParameter("@SupplierID", SupplierID);

            // run the query
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");

            // if exactly one record comes back, map it to the fields
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                dateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedDate"]);
                email = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
                name = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                isActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                phoneNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);

                return true;
            }

            // no match found
            return false;
        }

        // validation method: checks all fields and returns any error messages
        public string Valid(
            string supplierName,
            string supplierEmail,
            string supplierAddress,
            string supplierPhoneNumber,
            DateTime supplierCreatedDate)
        {
            // error builer string
            string Error = "";

            // --------- SUPPLIER NAME CHECKS ---------

            if (supplierName.Length == 0)
                Error += "supplier name cannot be blank , ";

            if (supplierName.Length > 50)
                Error += "supplier name must be less than 50 characters , ";

            // --------- SUPPLIER EMAIL CHECKS ---------

            if (supplierEmail.Length == 0)
                Error += "supplier email cannot be blank , ";

            if (supplierEmail.Length > 50)
                Error += "supplier email must be less than 50 characters , ";

            if (!supplierEmail.Contains("@"))
                Error += "email must contain @ , ";

            // --------- SUPPLIER ADDRESS CHECKS ---------

            if (supplierAddress.Length == 0)
                Error += "supplier address cannot be blank , ";

            if (supplierAddress.Length > 50)
                Error += "supplier address must be less than 50 characters , ";

            // --------- SUPPLIER PHONE NUMBER CHECK ---------

            if (supplierPhoneNumber.Length == 0)
                Error += "phone number cannot be blank , ";

            if (supplierPhoneNumber.Length > 20)
                Error += "phone number must be less than 20 characters , ";

            if (!supplierPhoneNumber.All(char.IsDigit))
                Error += "phone number must contain only digits , ";

            // --------- SUPPLIER CREATED DATE CHECK ----------

            if (supplierCreatedDate > DateTime.Now.Date)
                Error += "date cannot be in the future , ";

            return Error;
        }
    }
}
