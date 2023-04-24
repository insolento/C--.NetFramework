using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem menuI1 = new MenuItem("IPhone 13 Pro", "This IPhone has charger and documents, new incredible camera, and chip", 1299.99);
            MenuItem menuI2 = new MenuItem("Samsung Tv210", "This is 65 inch Oled display tv with the newest SamsungTV system", 699.99);
            OrderItem orderI1 = new OrderItem(menuI1);
            OrderItem orderI2 = new OrderItem(menuI2);
            Customer c1 = new Customer(1, "Nikita", "Bulford Ave 77", 2342342341);
            DateTime orderTime1 = new DateTime(2022, 12, 12);
            DateTime deliveryTime1 = new DateTime(2023, 1, 10);
            OrderItem[] orders1 = { orderI1 };
            Order order1 = new Order(1, c1, orderTime1, deliveryTime1, "phoneOrder", orders1);
            order1.MakeOrderItem(orderI2);
            Console.WriteLine(menuI1.ToString());
            Console.WriteLine(orderI1.ToString());
            Console.WriteLine(c1.ToString());
            Console.WriteLine(order1.ToString());
        }
    }
}
