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
        //Private data member for the IsGuestOrder property
        private bool mIsGuestOrder;
        //Private data member for the ProductID property
        private int mProductID;
        //Private data member for the Status property
        private string mOrderStatus;

        //IsGuestOrder public property
        public bool IsGuestOrder
        {
            get { return mIsGuestOrder; }
            set { mIsGuestOrder = value; }
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
        public string Status
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
                mIsGuestOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["isGuestOrder"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"])?.Trim();
                //Return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false
                return false;
            }
        }
    }
}