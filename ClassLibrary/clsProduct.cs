using System;  

namespace ClassLibrary
{
    public class clsProduct
    {
        public int ProductAmount;
        public DateTime StockArrivalDate;
        public int SupplierID;
        public bool InStock;
        public string ProductName;

        public int ProductID { get; set; }
    }
}