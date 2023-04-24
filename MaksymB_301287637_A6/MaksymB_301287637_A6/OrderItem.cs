using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    internal class OrderItem
    {
        IMenuItem item;

        internal OrderItem()
        {
            //default constructor
        }

        internal OrderItem(IMenuItem menuItem)
        {
            Item = menuItem;
            Cost = menuItem.BaseCost;
        }

        public decimal Cost { get; set; }

        public IMenuItem Item { 
            get
            {
                return item;
            } private set
            {
                item = value;
            }   
         }

        public override string ToString()
        {
            return $"In this order item just keeps menu item instance";
        }
    }
}
