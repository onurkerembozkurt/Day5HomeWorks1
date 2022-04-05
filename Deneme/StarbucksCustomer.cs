using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
   
    class StarbucksCustomer:CustomerManager,ICustomer
    {

        public int YildizSayisi = 1;
        public void AddStar(StarbucksCustomer customer)
        {
            Console.WriteLine("Musteri nin Yıldız sayisi"+customer.YildizSayisi);
        }
    }
}
