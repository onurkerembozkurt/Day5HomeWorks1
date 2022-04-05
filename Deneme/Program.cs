using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StarbucksCustomer sCustomer = new StarbucksCustomer();
            NeroCustomer nCustomer = new NeroCustomer();
            nCustomer.Add();
            ICustomer[] customers = new CustomerManager[2] { new NeroCustomer(),  sCustomer};
            foreach (var customer in customers)
            {
                customer.Add();
               
                

            }
        }
    }
}
//=new ICustomerDal[2] { new SqlServerCustomerDal(), new OracleCustomerDal()};