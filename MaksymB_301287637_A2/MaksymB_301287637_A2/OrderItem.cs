using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A2
{
    internal class OrderItem
    {
        MenuItem menuItem;

        internal OrderItem()
        {
            //default constructor
            MenuItem = new MenuItem();
        }

        internal OrderItem(MenuItem menuItem)
        {
            MenuItem = menuItem;
        }

        public MenuItem MenuItem
        {
            get
            {
                return menuItem;
            }
            set
            {
                menuItem = MenuItem;
            }
        }

        public override string ToString()
        {
            Console.WriteLine(GetPrice());
            return $"In this order item just keeps menu item instance";
        }

        public double GetPrice()
        {
            MenuItem mI = MenuItem;
            if (mI != null)
            {
                return mI.Cost;

            }
            else
            {
                return 0;
            }
        }
    }
}
