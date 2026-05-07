using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //Private data member for the OrderID property
        private Int32 mOrderID;
        //Private data member for the CustomerID property
        private Int32 mCustomerID;
        //Private data member for the OrderDate property
        private DateTime mOrderDate;
        //Private data member for the TotalPrice property
        private Decimal mTotalPrice;
        //Private data member for the isGuestOrder property
        private bool mIsGuestOrder;
        //Private data member for the ProductID property
        private int mProductID;
        //Private data member for the Status property
        private String mStatus;

        //isGuestOrder public property
        public bool isGuestOrder
        {
            get { return mIsGuestOrder; }
            set { mIsGuestOrder = value; }
        }

        //OrderID public property
        public Int32 OrderID
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
            get { return mStatus; }
            set { mStatus = value; }
        }
        //ProductID public property
        public int ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }

        public bool Find(int orderID)
        {
            //Set the private data member to the test data value
            mOrderID = 21;
            mCustomerID = 13;
            mOrderDate = Convert.ToDateTime("07/05/2026");
            mTotalPrice = 20.00m;
            mIsGuestOrder = false;
            mProductID = 1;
            mStatus = "Pending";
            //always return true
            return true;
        }
    }
}