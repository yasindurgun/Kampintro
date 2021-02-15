using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Name = "Yasin";
            //customer1.Surname = "Durgun";
            //customer1.Id= 1;
            //customer1.TcNo = "22222222222";
            //customer1.CustomerNo = "123456";
            //customer1.CompanyName = "?";

            //Gerçek != Tüzel

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "123456";
            customer1.Name = "Yasin";
            customer1.Surname = "Durgun";
            customer1.TcNo = "1234567890";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "654321";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer ();
            customer3.Id = 3;
            Customer customer4 = new CorporateCustomer();
            customer4.Id = 4;
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
