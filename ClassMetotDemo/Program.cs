using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.name = "Yasin";
            customer1.surname = "Durgun";
            customer1.address = "Ordu";

            Customer customer2 = new Customer();
            customer2.name = "Ataberk";
            customer2.surname = "Kurumoğlu";
            customer2.address = "Adana";

            Customer customer3 = new Customer();
            customer3.name = "Utku";
            customer3.surname = "Gök";
            customer3.address = "Ankara";

            //array
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.List(customers);

            customerManager.Delete(customer1);

            Console.ReadKey();
        }
    }
}
