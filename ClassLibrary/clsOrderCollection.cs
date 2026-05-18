using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsOrderCollection
    {
        //private data member for ThisOrder
        clsOrder mThisOrder = new clsOrder();


        //constructor for the class
        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = DB.DataTable.Rows[Index]["OrderID"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);

                AnOrder.CustomerID = DB.DataTable.Rows[Index]["CustomerID"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);

                AnOrder.ProductID = DB.DataTable.Rows[Index]["ProductID"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.OrderDate = DB.DataTable.Rows[Index]["OrderDate"] == DBNull.Value
                    ? DateTime.MinValue
                    : Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.TotalPrice = DB.DataTable.Rows[Index]["TotalPrice"] == DBNull.Value
                    ? 0
                    : Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.OrderStatus = DB.DataTable.Rows[Index]["OrderStatus"] == DBNull.Value
                    ? string.Empty
                    : Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.isGuestOrder = DB.DataTable.Rows[Index]["isGuestOrder"] == DBNull.Value
                    ? false
                    : Convert.ToBoolean(DB.DataTable.Rows[Index]["isGuestOrder"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
        //Private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
        {
            get { return mOrderList; }
            set { mOrderList = value; }
        }

        public int Count
        {   get { return mOrderList.Count; }
            set { /* do nothing */ }
        }

        public clsOrder ThisOrder
        {
            //Return the private data member
            get { return mThisOrder; }
            //Set the private data member to the value passed in
            set { mThisOrder = value; }
        }

        public int Add()
        {
            //Adds a new record to the database based on the values of ThisOrder
            //Set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //Add the parameters for the record
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@isGuestOrder", mThisOrder.isGuestOrder);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);

            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}