using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("The customer " + customer.name + " " + customer.surname + " added from "+customer.address+"\n");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("The customer " + customer.name + " " + customer.surname + " deleted from " + customer.address+"\n");
        }

        public void Delete2(Customer customer, int number, List<Customer> customers)
        {
            Console.WriteLine("Enter the number of customer to delete: ");
            number = Convert.ToInt32(Console.ReadLine());
            customers.RemoveAt(number - 1);
            Console.WriteLine("The customer " + customer.name + " " + customer.surname + " deleted from " + customer.address + "\n");
        }

        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Name: " + customer.name);
                Console.WriteLine("Customer Surname: " + customer.surname);
                Console.WriteLine("Customer Address: " + customer.address);
                Console.WriteLine("\n*****************\n");
            }
        }

        public void List2(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Name: " + customer.name);
                Console.WriteLine("Customer Surname: " + customer.surname);
                Console.WriteLine("Customer Address: " + customer.address);
                Console.WriteLine("\n*****************\n");
            }
        }
    }
}
