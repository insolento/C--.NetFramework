using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    abstract class MenuItemAddition : MenuItem
    {
        protected IMenuItem menuItem;
        public override decimal BaseCost { 
            get
            {
                return baseCost + menuItem.BaseCost;
            } set
            {
                baseCost = value;
            } 
        }
        public override string Description
        {
            get
            {
                return $"{menuItem.Description}, {description}";
            }

            set
            {
                description = value;
            }
        }

        internal MenuItemAddition(IMenuItem menuItem)
        {
            this.menuItem = menuItem;
        }
    }
}
