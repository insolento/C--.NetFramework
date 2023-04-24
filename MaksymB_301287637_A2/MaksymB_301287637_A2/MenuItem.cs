using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A2
{
    internal class MenuItem
    {
        string name;
        string description;
        double cost;


        internal MenuItem()
        {
            Name = "no name";
            Description = "no description";
            Cost = 0;
        }

        internal MenuItem(string name, string description, double cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
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
        public string Description
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
        public double Cost
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

        public override string ToString()
        {
            return $"Menu item has name {Name}, and cost {Cost:c}, with description: {Description}";
        }
    }
}
