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

        public string Valid(string productName, string productAmount, string stockArrivalDate, string supplierID)
        {
            String Error = "";
            DateTime DateTemp;

            //Product Name validation
            if (productName.Length == 0)
            {
                Error = Error + "The product name may not be blank : ";
            }
            else if (productName.Length > 50)
            {
                Error = Error + "The product name must be less than 50 characters : ";
            }

            //Product Amount validation
            if (productAmount.Length == 0)
            {
                Error = Error + "The product amount may not be blank : ";
            }
            else
            {
                int amount;
                if (!Int32.TryParse(productAmount, out amount))
                {
                    Error = Error + "The product amount must be a number : ";
                }
                else if (amount <= 0)
                {
                    Error = Error + "The product amount must be greater than 0 : ";
                }
            }


            //Stock Arrival Date validation
            if (stockArrivalDate.Length == 0)
            {
                Error = Error + "The stock arrival date may not be blank : ";
            }
            else if (!DateTime.TryParse(stockArrivalDate, out DateTemp))
            {
                Error = Error + "The stock arrival date is not a valid date : ";
            }
            else
            {
                // Use date-only comparisons to avoid time-of-day flakiness
                DateTime dateOnly = DateTemp.Date;
                DateTime min = DateTime.Today.AddDays(-30);
                DateTime max = DateTime.Today.AddDays(30);

                if (dateOnly < min || dateOnly > max)
                {
                    Error = Error + "The stock arrival date must be within 30 days of today : ";
                }
            }


            //Supplier ID validation
            if (supplierID.Length == 0)
            {
                Error = Error + "The supplier ID may not be blank : ";
            }
            else
            {
                int id;
                if (!Int32.TryParse(supplierID, out id))
                {
                    Error = Error + "The supplier ID must be a number : ";
                }
                else if (id <= 0)
                {
                    Error = Error + "The supplier ID must be greater than 0 : ";
                }
            }

            return Error;
        }
    }
}