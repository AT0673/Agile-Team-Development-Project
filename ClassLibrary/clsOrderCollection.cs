using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsOrderCollection
    {
        //private data member for ThisOrder
        clsOrder mThisOrder = new clsOrder();

        void PopulateArray(clsDataConnection DB)
        {
            {
                //variable for the index
                Int32 Index = 0;
                //variable to store the record count
                Int32 RecordCount = 0;
                //get the count of records
                RecordCount = DB.Count;
                //clear the private array list
                mOrderList = new List<clsOrder>();
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
        }


        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
            //Update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Add the parameters for the record
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@isGuestOrder", mThisOrder.isGuestOrder);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            //Execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the record
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //Execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderStatus(string OrderStatus)
        {
            //filters the records by order status
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the order status parameter to the database
            DB.AddParameter("@OrderStatus", OrderStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderStatus");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}