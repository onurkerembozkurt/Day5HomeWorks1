using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
          ICustomerDal[] customerDals =new ICustomerDal[2] { new SqlServerCustomerDal(), new OracleCustomerDal()};
            
        foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }
            

        }

        private static void RealLifeInterfaceOne()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer();
            customer.Address = "mALALHLDG";
            customer.MyProperty = 123;
            PersonManager manager = new PersonManager();
            manager.Add(customer);

            Student student = new Student();
            student.Departmant = "computer science";
            student.MyProperty = 1;
        }

        interface IPerson
        {
            /*
             * Interface ler soyut tur 
             */
            public int MyProperty { get; set; }
        }
        class Customer : IPerson
        {
            public int MyProperty { get; set; }
            public string Address { get; set; }

        }
        class Student:IPerson
        {
            public int MyProperty { get; set; }
            public string  Departmant { get; set; }
           
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.MyProperty);
            }
        }
       
    }
}
/*iki class da IPerson dan implemente oldu student a ayrı Customer a ayrı özellik verildi
 * Implemente oldugu için IPersondan gidebiliriz yani interfacelerden referanslara ulaşabiliriz
 * 
 * 
 * 
 *   //Interfacesler Hiçbir zaman newlenemez çünkü tek başlarına bir anlamı yoktur.
            // IPerson person = new IPerson(); interface in instance oluşturamazsın der
            //ama
            IPerson person = new Customer();
            //İnterfaceler ve abstract classlar newlenemez çünkü Soyutturlar Abstractırlardır yani
 * 
 */