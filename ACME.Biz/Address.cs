using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Biz
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

    }
}