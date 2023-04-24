using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A2
{
    internal class Order
    {
        int id;
        Customer customer;
        DateTime orderTime;
        DateTime deliveryTime;
        string deliveryAddress;
        double cost;
        string orderType; //should be string not like in doc
        OrderItem[] items;

        internal Order()
        {
            // default constructor
            Id = 0;
            OrderTime = new DateTime();
            DeliveryTime = new DateTime();
            DeliveryAddress = "no address";
            orderType = "No order type";
        }

        internal Order(int id)
        {

            Id = id;
            OrderTime = new DateTime();
            DeliveryTime = new DateTime();
            DeliveryAddress = "no address";
            orderType = "No order type";
        }

        internal Order(int id, Customer customer, DateTime orderTime, DateTime deliveryTime, string orderType, OrderItem[] items)
        {
            Id = id;
            Customer = customer;
            OrderTime = orderTime;
            DeliveryTime = deliveryTime;
            DeliveryAddress = DeliveryAddress;
            OrderType = orderType;
            Items = items;
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

        public Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
                DeliveryAddress = value.Address;
            }
        }

        public DateTime OrderTime
        {
            get
            {
                return orderTime;
            }

            set
            {
                orderTime = value;
            }
        }

        public DateTime DeliveryTime
        {
            get
            {
                return deliveryTime;
            }

            set
            {
                deliveryTime = value;
            }
        }

        public string DeliveryAddress
        {
            get
            {
                return deliveryAddress;
            }

            set
            {
                deliveryAddress = value;
            }
        }

        public double Cost
        {
            get
            {
                double totalPrice = 0;
                foreach (OrderItem i in Items)
                {
                    double itemCost = i.GetPrice();
                    if (itemCost != null)
                    {
                        totalPrice += itemCost;
                    }
                }
                cost = totalPrice;
                return cost;
            }

            private set
            {

                cost = value;
            }
        }

        public string OrderType
        {
            get
            {
                return orderType;
            }

            set
            {
                orderType = value;
            }
        }

        public OrderItem[] Items
        {
            get
            {
                return items;
            }

            private set
            {
                double totalPrice = 0;
                foreach (OrderItem i in value)
                {
                    double itemCost = i.GetPrice();
                    if (itemCost != null)
                    {
                        totalPrice += itemCost;
                    }
                }
                Cost = totalPrice;
                items = value;
            }
        }

        public void MakeOrderItem(OrderItem item)
        {
            Items.Append(item);
        }

        public override string ToString()
        {
            return $"Customer id is {Id}, order time is {OrderTime}, delivery time is {DeliveryTime}, delivery address is {DeliveryAddress}, total order cost is {cost:c}, order type is {OrderType}";
        }

    }
}
