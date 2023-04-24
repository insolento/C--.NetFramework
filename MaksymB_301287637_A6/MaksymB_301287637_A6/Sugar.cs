using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    internal class Sugar:MenuItemAddition
    {
        internal Sugar(IMenuItem item): base(item)
        {
            Description = $"Sugar";
            BaseCost = 0.05M;

        }
    }
}
