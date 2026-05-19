using System;
using System.Collections.Generic;
using ClassLibrary;


namespace ClassLibrary
{
    public class clsProductCollection
    {
        List<clsProduct> mProductList = new List<clsProduct>();

        clsProduct mThisProduct = new clsProduct();
        public clsProductCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProduct_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AProduct.ProductAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductAmount"]);
                AProduct.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AProduct.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AProduct.StockArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockArrivalDate"]);
                mProductList.Add(AProduct);
                Index++;
            }
        }

        public List<clsProduct> ProductList
        {             get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }
        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set
            {
                // This setter is not necessary as Count is derived from the list, but it's included for testing purposes.
            }
        }
        public clsProduct ThisProduct
        {   get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductAmount", mThisProduct.ProductAmount);
            DB.AddParameter("@SupplierID", mThisProduct.SupplierID);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@StockArrivalDate", mThisProduct.StockArrivalDate);
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductAmount", mThisProduct.ProductAmount);
            DB.AddParameter("@SupplierID", mThisProduct.SupplierID);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@StockArrivalDate", mThisProduct.StockArrivalDate);
            DB.Execute("sproc_tblProduct_Update");
        }
    }
}