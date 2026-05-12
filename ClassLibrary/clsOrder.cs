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
        //Private data member for the OrderStatus property
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
        //OrderStatus public property
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
                //Set the private data member to the test data value
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                //Check if CustomerID is not DBNull before converting (this handles the case where CustomerID might be null in the database (e.g. a guest order))
                if (DB.DataTable.Rows[0]["CustomerID"] != DBNull.Value)
                    mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                else
                    mCustomerID = 0; // or handle as appropriate
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                misGuestOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["isGuestOrder"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"])?.Trim();
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

            // CustomerID checks
            if (CustomerID.Length == 0)
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
                        Error = Error + "TotalPrice must be greater than 0 : ";
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
            else if (OrderStatus.Length > 50)
            {
                Error = Error + "The OrderStatus must be less than or equal to 50 characters : ";
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
