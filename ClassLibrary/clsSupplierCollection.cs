using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        // private fields
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        // public properties
        public List<clsSupplier> Supplierlist
        {
            get { return mSupplierList; }
            set { mSupplierList = value; }
        }

        // count of suppliers in the list
        public int Count
        {
            get { return mSupplierList.Count; }
            set { /* not needed */ }
        }

        // public access to the "current" supplier
        public clsSupplier ThisSupplier
        {
            get { return mThisSupplier; }
            set { mThisSupplier = value; }
        }

        // constructor: loads all suppliers from the database on startup
        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }

        // add a new supplier to the database
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            // pass all supplier fields into the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Address", mThisSupplier.SupplierAddress);
            DB.AddParameter("@ContactEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@ContactPhone", mThisSupplier.SupplierPhoneNumber);
            DB.AddParameter("@CreatedDate", mThisSupplier.SupplierCreatedDate);
            DB.AddParameter("@IsActive", mThisSupplier.SupplierActive);

            // run insert and return the new primary key
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        // update an existing supplier record
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Address", mThisSupplier.SupplierAddress);
            DB.AddParameter("@ContactEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@ContactPhone", mThisSupplier.SupplierPhoneNumber);
            DB.AddParameter("@CreatedDate", mThisSupplier.SupplierCreatedDate);
            DB.AddParameter("@IsActive", mThisSupplier.SupplierActive);

            DB.Execute("sproc_tblSupplier_Update");
        }

        // delete the current supplier from the database
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        // filter suppliers by name (partial matches allowed)
        public void ReportBySupplierName(string SupplierName)
        {
            clsDataConnection DB = new clsDataConnection();

            if (SupplierName == "")
            {
                // no filter then return all suppliers
                DB.Execute("sproc_tblSupplier_SelectAll");
            }
            else
            {
                // wildcards LIKE can match partial names
                DB.AddParameter("@SupplierName", "%" + SupplierName + "%");
                DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            }

            PopulateArray(DB);
        }

        // this method loads database rows into the supplier list
        public void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = DB.Count;

            // reset the list before filling it
            mSupplierList = new List<clsSupplier>();

            // loop through each row returned from the database
            while (Index < RecordCount)
            {
                clsSupplier aSupplier = new clsSupplier();

                // map database fields into the supplier object
                aSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                aSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                aSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                aSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                aSupplier.SupplierPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                aSupplier.SupplierCreatedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedDate"]);
                aSupplier.SupplierActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);

                // add to the list
                mSupplierList.Add(aSupplier);

                Index++;
            }

            // sort by SupplierID so results are predictable for tests
            mSupplierList = mSupplierList.OrderBy(s => s.SupplierID).ToList();
        }
    }
}
