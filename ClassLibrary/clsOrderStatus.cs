using System;

namespace ClassLibrary
{
    public class clsOrderStatus
    {
        public string DefaultStatus
        {
            get { return "Pending"; }
        }

        public string[] AllStatuses
        {
            get
            {
                return new string[] { "Pending", "Processing", "Dispatched", "Delivered", "Cancelled" };
            }
        }

        public bool IsValidStatus(string OrderStatus)
        {
            if (OrderStatus == null)
            {
                return false;
            }

            foreach (string Status in AllStatuses)
            {
                if (String.Equals(OrderStatus, Status, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
