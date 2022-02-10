using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("customer added : " + customer.Name +" " +  customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("customer deleted : " + customer.Name + " " + customer.LastName);
        }

        public void List(Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine(customers.Name+" "+ customers.LastName);
            }
        }

    }
}
