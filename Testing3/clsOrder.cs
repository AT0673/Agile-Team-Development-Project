using System;

namespace Testing3
{
    public class clsOrder
    {
        internal bool isGuestOrder;

        public int OrderID { get; internal set; }
        public int CustomerID { get; internal set; }
        public DateTime OrderDate { get; internal set; }
        public decimal TotalPrice { get; internal set; }
        public string Status { get; internal set; }
        public int ProductID { get; internal set; }
    }
}