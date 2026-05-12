using System;  

namespace ClassLibrary
{
    public class clsProduct
    {
        private Int32 mProductID;
        private string mProductName;
        private Int32 mProductAmount;
        private Int32 msupplierID;
        private bool mInStock;
        private DateTime mStockArrivalDate;

        public int ProductAmount
        {
            get
            {
                return mProductAmount;
            }
            set
            {
                mProductAmount = value;
            }
        }
        public DateTime StockArrivalDate
        {
            get
            {
                return mStockArrivalDate;
            }
            set
            {
                mStockArrivalDate = value;
            }
        }
        public int SupplierID
        {
            get
            {
                return msupplierID;
            }
            set
            {
                msupplierID = value;
            }
        }
        public bool InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public Int32 ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        } 

        public bool Find(int productID)
        {
            clsDataConnection DB = new clsDataConnection();
                
            DB.AddParameter("@ProductID", productID);  

            DB.Execute("sproc_tblProduct_FilterByProductID");

            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductAmount = Convert.ToInt32(DB.DataTable.Rows[0]["ProductAmount"]);
                msupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mStockArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StockArrivalDate"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}