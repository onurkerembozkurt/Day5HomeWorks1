using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
