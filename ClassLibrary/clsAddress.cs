using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary
{

    public class clsAddress
    {
        public bool Active { get; set; }

        public DateTime DateAdded { get; set; }

        public int AddressId { get; set; }

        public int CountyCode { get; set; }

        public string HouseNo { get; set; }

        public string PostCode { get; set; }

        public string Street { get; set; }

        public string Town { get; set; }
    }
}
