using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    internal struct Address
    {
        public string City;
        public string PostalCode;
        public string Province;
        static public readonly Address SHOP_ADDRESS = new Address(" 1 King St.","Toronto","ON","M1M 1M1");
        public string Street;

        internal Address(string street, string city, string province, string postalCode)
        {
            Street = street;
            City = city;
            Province = province;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Province} {PostalCode}";
        }
    }
}
