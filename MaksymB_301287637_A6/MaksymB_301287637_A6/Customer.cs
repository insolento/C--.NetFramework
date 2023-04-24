using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    internal class Customer
    {

        private static ulong idNumber = 0;
        string name;
        Address address;
        uint phone;
        List<Order> orders = new List<Order>();

        internal Customer()
        {
            idNumber ++;
        }

        internal Customer(string name, uint telephoneNumber, Address address)
        {
            Address = address;
            Phone = telephoneNumber;
            Name = name;
            idNumber ++; ;
        }

        public ulong IdNumber
        {
            get
            {
                return idNumber;
            }
            private set
            {
                if (value > 0)
                {
                    idNumber = value;
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

        public Address Address
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

        public uint Phone
        {
            get
            {
                return phone;
            }
            set
            { 
                phone = value;
            }
        }

        public List<Order> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public Order CreatePhoneOrder(Address deliveryAddress)
        {
            Order order = new Order() { OrderType=OrderType.PhoneOrder, DeliveryAddress = deliveryAddress };
            AddOrder(order);
            return order;
        }

        public override string ToString()
        {
            string output = $"Customer: Id:{IdNumber}, Name:{Name},\n\t\t Address:{Address}, Phone:{Phone}\n\tOrders:\n";
            foreach (Order order in orders)
            {
                output += $"\t\tOrder: Id: {order.OrderId}\n\t\tCustomer name: {Name}\n\t\tOrder time: {order.OrderTime.ToString("t")}\n\t\tCost: {order.Cost:c}\n\t\tDelivery address: {order.DeliveryAddress}\n\t\tOrder items: {order.Items.Count}";
                foreach (OrderItem item in order.Items)
                {
                    try
                    {
                        output += $"\n\t\t{item.Item.Description} - {item.Item.BaseCost:c}";
                    } catch (Exception e) {}
                }
                output += $"\n\n";
            }
            return output;
        }
    }
}
