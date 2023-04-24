using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A6
{
    internal class CustomerRepository: RepositoryBase
    {

        internal CustomerRepository()
        {
            Customers = new List<Customer>();
        }
        public override List<Customer> Customers { get; set; }

        public void Add(Customer customer) { 

            Customers.Add( customer );
        }
    }
}
