using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "ipek";
            customer1.LastName = "ozbay";
            
            Customer customer2 = new Customer();
            customer2.Name = "berkay";
            customer2.LastName = "kavuk";

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2 };

            customerManager.Add(customer2);
            customerManager.Add(customer1);
            customerManager.List(customers);
            customerManager.Delete(customer1);

        }

    }
}
