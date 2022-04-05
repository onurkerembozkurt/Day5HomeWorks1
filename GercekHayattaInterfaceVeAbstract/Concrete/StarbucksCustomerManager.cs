using GercekHayattaInterfaceVeAbstract.Abstract;
using GercekHayattaInterfaceVeAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GercekHayattaInterfaceVeAbstract.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerService  _customerCheckService;

        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

       
    }
}
/**
 * public class StarbucksCustomerManager:BaseCustomerManager,ICustomerCheckService
    {
        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

       
    }
diyerek implemente edebiliriz ki bu birinci kullanım yani yarın bigün neroya da özgü olabilir
 */
