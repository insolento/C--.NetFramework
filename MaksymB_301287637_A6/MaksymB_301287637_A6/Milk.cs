using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    internal class Milk: MenuItemAddition
    {
        internal Milk(IMenuItem item) : base(item)
        {
            Description = $"Milk";
            BaseCost = .10M;
        }
    }
}
