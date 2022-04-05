using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbucksCustomerManager:BaseCustomerManager
    {
        private IPersonCheckService _customerCheckService;
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
                base.Save(customer);
            else
                throw new Exception("Not a valid person");

            

        }

     
    }
}
/*abstract class içerisinde override edebilmek için virtual yazmıştık şimdi burada bi boşluğa gelip
 * override yazıyoruz save geliyor zaten
 * 
 */