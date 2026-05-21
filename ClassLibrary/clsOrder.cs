using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //Private data member for the OrderID property
        private int mOrderID;
        //Private data member for the CustomerID property
        private int mCustomerID;
        //Private data member for the OrderDate property
        private DateTime mOrderDate;
        //Private data member for the TotalPrice property
        private decimal mTotalPrice;
        //Private data member for the isGuestOrder property
        private bool misGuestOrder;
        //Private data member for the ProductID property
        private int mProductID;
        //Private data member for the Status property
        private string mOrderStatus;

        //isGuestOrder public property
        public bool isGuestOrder
        {
            get { return misGuestOrder; }
            set { misGuestOrder = value; }
        }

        //OrderID public property
        public int OrderID
        {
            //this line of code sends data out of the property
            get { return mOrderID; }
            //this line of code allows data into the property
            set { mOrderID = value; }
        }
        //  CustomerID public property
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }
        //OrderDate public property
        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }
        //TotalPrice public property
        public decimal TotalPrice
        {
            get { return mTotalPrice; }
            set { mTotalPrice = value; }
        }
        //Status public property
        public string OrderStatus
        {
            get { return mOrderStatus; }
            set { mOrderStatus = value; }
        }
        //ProductID public property
        public int ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }

        //OrderSummary public property used to make the order list easier to read
        public string OrderSummary
        {
            get
            {
                return "Order " + mOrderID.ToString()
                    + " | Customer " + mCustomerID.ToString()
                    + " | " + mOrderStatus
                    + " | GBP " + mTotalPrice.ToString("0.00")
                    + " | " + mOrderDate.ToShortDateString();
            }
        }

        public bool Find(int orderID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", orderID);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //If one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                var row = DB.DataTable.Rows[0];

                // OrderID is required - if it's DBNull treat as not found
                if (row["OrderID"] != DBNull.Value)
                    mOrderID = Convert.ToInt32(row["OrderID"]);
                else
                    return false;

                // CustomerID might be null for guest orders
                if (row["CustomerID"] != DBNull.Value)
                    mCustomerID = Convert.ToInt32(row["CustomerID"]);
                else
                    mCustomerID = 0;

                // OrderDate - guard against DBNull
                if (row["OrderDate"] != DBNull.Value)
                    mOrderDate = Convert.ToDateTime(row["OrderDate"]);
                else
                    mOrderDate = DateTime.MinValue;

                // TotalPrice - guard against DBNull
                if (row["TotalPrice"] != DBNull.Value)
                    mTotalPrice = Convert.ToDecimal(row["TotalPrice"]);
                else
                    mTotalPrice = 0m;

                // isGuestOrder - guard against DBNull
                if (row["isGuestOrder"] != DBNull.Value)
                    misGuestOrder = Convert.ToBoolean(row["isGuestOrder"]);
                else
                    misGuestOrder = false;

                // ProductID - guard against DBNull
                if (row["ProductID"] != DBNull.Value)
                    mProductID = Convert.ToInt32(row["ProductID"]);
                else
                    mProductID = 0;

                // OrderStatus - guard against DBNull
                if (row["OrderStatus"] != DBNull.Value)
                    mOrderStatus = Convert.ToString(row["OrderStatus"]).Trim();
                else
                    mOrderStatus = string.Empty;

                //Return that everything worked OK
                return true;
            }
            //If no record was found
            else
            {
                //Return false, indicating a problem
                return false;
            }
        }

        public string Valid(string CustomerID, string OrderDate, string TotalPrice,
                            string OrderStatus, string isGuestOrder, string ProductID)
        {
            String Error = "";
            DateTime DateTemp;
            Boolean GuestOrder = false;
            Boolean.TryParse(isGuestOrder, out GuestOrder);

            // CustomerID checks
            if (GuestOrder)
            {
                if (CustomerID.Length != 0)
                {
                    Error = Error + "Guest orders must not have a CustomerID : ";
                }
            }
            else if (CustomerID.Length == 0)
            {
                Error = Error + "The CustomerID may not be blank : ";
            }
            else
            {
                long custVal;
                if (!long.TryParse(CustomerID, out custVal))
                {
                    // Not numeric or out of range for long
                    Error = Error + "The CustomerID must be a valid number : ";
                }
                else
                {
                    if (custVal <= 0)
                    {
                        Error = Error + "The CustomerID must be greater than 0 : ";
                    }
                    else if (custVal > Int32.MaxValue)
                    {
                        // Detect values too large for an int and show your specific message
                        Error = Error + "The CustomerID must be less than or equal to 2,147,483,647 : ";
                    }
                }
            }

            //Date checks
            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The OrderDate cannot be in the past : ";
                }

            }
            catch
            {
                Error = Error + "The OrderDate is not a valid date : ";
            }


            //TotalPrice checks
            if (TotalPrice.Length == 0)
            {
                Error = Error + "The total price should not be blank : ";
            }
            else
            {
                try
                {
                    decimal TotalPriceValue = Convert.ToDecimal(TotalPrice);
                    if (TotalPriceValue <= 0)
                    {
                        Error = Error + "TotalPrice must be greater then 0 : ";
                    }
                    else if (TotalPriceValue >= 10000000m) // Reject 10,000,000.00 and above
                    {
                        Error = Error + "TotalPrice must be less than 10,000,000 : ";
                    }
                }
                catch
                {
                    Error = Error + "The TotalPrice is not a valid decimal number : ";
                }
            }

            //OrderStatus checks
            if (OrderStatus.Length == 0)
            {
                Error = Error + "The OrderStatus may not be blank : ";
            }
            else
            {
                clsOrderStatus OrderStatusRules = new clsOrderStatus();

                if (OrderStatusRules.IsValidStatus(OrderStatus) == false)
                {
                    Error = Error + "The OrderStatus must be Pending, Processing, Dispatched, Delivered or Cancelled : ";
                }
            }

            //ProductID checks
            if (ProductID.Length == 0)
            {
                Error = Error + "The ProductID may not be blank : ";
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(ProductID) <= 0)
                    {
                        Error = Error + "The ProductID must be greater than 0 : ";
                    }
                }
                catch
                {
                    Error = Error + "The ProductID must be a valid number : ";
                }
            }

            return Error;
        }
    }
}
