using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "customer added.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "customer deleted.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.PhoneNumber);
            Console.WriteLine(customer.Email);
        }
    }


}
