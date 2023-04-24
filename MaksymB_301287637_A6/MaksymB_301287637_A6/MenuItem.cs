using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MaksymB_301287637_A6
{
    abstract class MenuItem: IMenuItem
    {
        [JsonProperty]
        public decimal baseCost;

        [JsonProperty]
        public string description;

        internal MenuItem()
        {

        }

        internal MenuItem(string description, decimal cost)
        { 
            this.Description = description;
            this.BaseCost = cost;
        }


        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public virtual decimal BaseCost
        {
            get
            {
                return baseCost;
            }
            set
            {
                baseCost = value;
            }
        }

        public override string ToString()
        {
            return $"Menu item: Description: {Description}\n\t Base Cost: {BaseCost:c}";
        }
    }
}
