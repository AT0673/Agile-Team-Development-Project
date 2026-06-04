using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> Supplierlist
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }


        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }



        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Address", mThisSupplier.SupplierAddress);
            DB.AddParameter("@ContactEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@ContactPhone", mThisSupplier.SupplierPhoneNumber);
            DB.AddParameter("@CreatedDate", mThisSupplier.SupplierCreatedDate);
            DB.AddParameter("@IsActive", mThisSupplier.SupplierActive);
            // execute the stored procedure once and return its return value
            int result = DB.Execute("sproc_tblSupplier_Insert");
            return result;
        }

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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            clsDataConnection DB = new clsDataConnection();
            if (SupplierName == "")
            {
                DB.Execute("sproc_tblSupplier_SelectAll");
            }
            else
            {
                // pass wildcards so stored procedure using LIKE will match partial names
                DB.AddParameter("@SupplierName", "%" + SupplierName + "%");
                DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            }
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier aSupplier = new clsSupplier();
                aSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                aSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                aSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                aSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                aSupplier.SupplierPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                aSupplier.SupplierCreatedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedDate"]);
                aSupplier.SupplierActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mSupplierList.Add(aSupplier);
                Index++;
            }
            // ensure deterministic ordering (ascending by SupplierID) so callers/tests get predictable results
            mSupplierList = mSupplierList.OrderBy(s => s.SupplierID).ToList();
        }
    }
}