using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Database");
        }
    }


}
/*Normalde interface i implemente edip ikisi içinde ayrı ayrı kodlar yazardım fakat 
 * veri tabanına aynı kodla kayıt olacaklar gerek yok o yüzden 
 * abstract lazım
 * şimdi starbucksta ekstra mersis dogrulaması istiyor ya bu save kodu içinde o yüzden ona ufak bi 
 * degisiklik yapmak lazım bu degisiklik içinde override edilmesi lazım 
 * bu fonksiyonun override edilmesi için ^^virtual^^ ifadesi koyacağız 
 * 
 */