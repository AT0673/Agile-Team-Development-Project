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
            mProductID = 2;
            mProductAmount = 0;
            mStockArrivalDate = DateTime.Now.Date;
            msupplierID = 0;
            mInStock = false;
            mProductName = "Product";
            return true;
        }
    }
}