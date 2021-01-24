using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.Adress = "İstanbul";
            customer1.PhoneNumber = "0123456789";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Baransel";
            customer2.LastName = "Yıldız";
            customer2.Adress = "İzmir";
            customer2.PhoneNumber = "05555555555";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Berkay";
            customer3.LastName = "Bilgin";
            customer3.Adress = "Bursa";
            customer3.PhoneNumber = "01010110101";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            List<Customer> customerList = new List<Customer>() {customer1, customer2, customer3 };

            customerManager.List();
            Console.WriteLine("---------------------");
            foreach (var item in customerList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }


        }
    }
}
