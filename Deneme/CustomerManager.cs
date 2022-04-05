using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
    class CustomerManager : ICustomer
    {
        public void Add()
        {
            Console.WriteLine("Veri Tabanına Kaydedildi.");
        }
        public void Madd(StarbucksCustomer customer)
        {
            Console.WriteLine("Mersis");
        }
       
        
    }
}
