using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary
{

    public class clsCustomer
    {
        public bool Active { get; set; }

        public DateTime DateAdded { get; set; }

        public int CustomerID { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerPassword { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }
    }
}
