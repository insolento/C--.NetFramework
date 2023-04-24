using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A2
{
    internal class Customer
    {
        int id;
        string name;
        string address;
        long telephoneNumber;
        Order[] orders;

        internal Customer()
        {
            id = 999;
            name = "no name";
            address = "no address";
            telephoneNumber = 0;
        }

        internal Customer(int id, string address, long telephoneNumber)
        {
            Id = id;
            Address = address;
            TelephoneNumber = telephoneNumber;
            name = "no name";
        }

        internal Customer(int id, string name, string address, long telephoneNumber)
        {
            Id = id;
            Address = address;
            TelephoneNumber = telephoneNumber;
            Name = name;
        }

        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (value > 0)
                {
                    id = value;
                }

            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public long TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }
            set
            {
                if (value.ToString().Length == 10)
                {
                    telephoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Not a phone number");

                }

            }
        }

        void CreateOrder(Order order)
        {
            orders.Append(order);
        }

        public override string ToString()
        {
            return $"Customer id is {Id}, customer's name is {Name}, customer's address is {Address}, customer's number is {TelephoneNumber}";
        }
    }
}
