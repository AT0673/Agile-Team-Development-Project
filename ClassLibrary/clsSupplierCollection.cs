using System;
using System.Collections.Generic;
using System.Data;
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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            clsSupplier TestItem = new clsSupplier();
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier aSupplier = new clsSupplier();
                aSupplier.SupplierActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                aSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                aSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                aSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                aSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                aSupplier.SupplierPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                aSupplier.SupplierCreatedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedDate"]);
                mSupplierList.Add(aSupplier);
                Index++;
            }
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
            DB.Execute("sproc_tblSupplier_Insert");
            return DB.Execute("sproc_tblSupplier_Insert");
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


    }
}