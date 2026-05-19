using System;
using System.Collections.Generic;
using System.Data;
namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

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


        public clsSupplier ThisSupplier { get; set; }

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
    }
}