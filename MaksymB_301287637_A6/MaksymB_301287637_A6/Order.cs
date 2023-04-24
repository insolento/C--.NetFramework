using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MaksymB_301287637_A6
{
    enum OrderType
    {
        PhoneOrder, RestaurantOrder
    }
    internal class Order
    {
        private static uint orderId;
        Customer customer;
        DateTime orderTime;
        DateTime deliveryTime;
        Address deliveryAddress;
        decimal cost;
        OrderType orderType;
        bool delivered;
        List<OrderItem> items = new List<OrderItem>();


        internal Order()
        {
            // default constructor
            OrderTime = DateTime.Now;
            OrderType = OrderType.RestaurantOrder;
            Delivered = true;
            DeliveryAddress= new Address("1King St.", "Toronto", "ON", "M1M 1M1");
            OrderId++;
        }

        internal Order(Customer customer, OrderType orderType, Address address)
        {

            OrderTime = DateTime.Now;
            Customer = customer;
            OrderType = orderType;
            DeliveryAddress = address;
            if (orderType == OrderType.PhoneOrder)
            {
                Delivered = false;
            }
            OrderId++;
        }

        public uint OrderId
        {
            get
            {
                return orderId;
            }

            private set
            {
                if (value > 0)
                {
                    orderId = value;
                }
            }
        }
        [JsonIgnore]
        public Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                if (customer != null)
                {
                    Console.WriteLine("Something went wrong! Customer cannot be changed once assigned");
                } else
                {
                    customer = value;
                }
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

        public bool Delivered
        {
            get
            {
                return delivered;
            }

            set
            {
                if (value)
                {
                    DeliveryTime = DateTime.Now;
                } else
                {
                    DeliveryTime = DateTime.MinValue;
                }
                delivered = value;
            }
        }

        public Address DeliveryAddress
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

        public decimal Cost
        {
            get
            {
                
                return cost;

            }

            private set
            {

                cost = value;
            }
        }

        public OrderType OrderType
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


        public List<OrderItem> Items
        {
            get
            {
                return items;
            }

            private set
            {
                items = value;

            }
        }

        public void AddOrderItem(IMenuItem menuItem)
        {
            OrderItem orderItem = new OrderItem(menuItem);
            this.items.Add(orderItem);
            Cost += menuItem.BaseCost;
        }

        public void Deliver()
        {
            Delivered = true;
            DeliveryTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Customer id is {OrderId}, order time is {OrderTime}, delivery time is {DeliveryTime}, delivery address is {DeliveryAddress}, total order cost is {cost:c}, order type is {OrderType}";
        }

    }
}
