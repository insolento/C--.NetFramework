using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MaksymB_301287637_A6
{
    abstract class RepositoryBase
    {
        public abstract List<Customer> Customers { get; set; }

        public void Load(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                        TypeNameHandling = TypeNameHandling.Auto
                    });
                    Customers = (List<Customer>)serializer.Deserialize(reader, typeof(object));
                    reader.Close();
                }
                file.Close();
            }
            //resolving circular reference
            foreach (Customer customer in Customers)
            {
                if (customer != null)
                {
                    foreach (Order order in customer.Orders)
                    {
                        order.Customer = customer;
                    }
                }
            }
        }

        public void Save(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                        TypeNameHandling = TypeNameHandling.All,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                    serializer.Serialize(writer, Customers);
                    writer.Close();
                }
                file.Close();
            }
            }
    }
}
