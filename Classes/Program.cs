using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Kerem";
            customer1.LastName = "Bozkurt";
            customer1.City = "İzmir";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "İstanbul", FirstName = "Süleyman", LastName = "Bozkurt"
            };
            Console.WriteLine(customer2.FirstName);
        }
    }


}