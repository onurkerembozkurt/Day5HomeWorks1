using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer { DateOfBirth=new DateTime(1923,4,2),FirstName="Kerem",LastName="Bozkurt",NationalityId="2132",Id=1})
            

        }
    }
}
