using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0;
            customer1.FirstName = "Baransel";
            customer1.LastName = "Yildiz";
            customer1.PhoneNumber = "05555555550";
            customer1.Email = "baranselyildiz@hotmail.com";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.PhoneNumber = "01230123012";
            customer2.Email = "engindemirog@gmail.com";

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "John";
            customer3.LastName = "Smith";
            customer3.PhoneNumber = "010101010101";
            customer3.Email = "johnsmith@hotmail.com";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("Add customer: ");
            customerManager.Add(customer1);
            Console.WriteLine("Delete customer: ");
            customerManager.Delete(customer2);
            Console.WriteLine("Customer List");
            Console.WriteLine("----------------");
            foreach (var item in customers)
            {
                customerManager.List(item);
                Console.WriteLine("-------------------");
            }


        }
    }
}
