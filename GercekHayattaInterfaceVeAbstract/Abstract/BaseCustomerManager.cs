using GercekHayattaInterfaceVeAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GercekHayattaInterfaceVeAbstract.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db "+customer.FirstName);
        }
    }
}
