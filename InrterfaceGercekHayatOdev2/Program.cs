using System;

namespace InrterfaceGercekHayatOdev2
{
    class Program
    {
        //Interface newlenemez
        //referance tipleri hatırlayın interface referans tiptir new customer manager dediğimizde heap kısmında 
        //customermanager oluşuyor
        //interfaceler onu implemente eden class ın referans numaraısnı tutabilirler.

        static void Main(string[] args)
        {
            IPersonManager customManager = new CustomerManager();
            customManager.Add();
            IPersonManager personManager = new EmployeeManager();
            personManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customManager);
        }
    }

    interface IPersonManager
    {
        //Unimplemented Operation
         void Add();
        void Update();
        
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }
    }
}
//classlarda inherits --------------- interfacelerde interface /
/*
 * Interfacelerden implemente alanlar interfacein içindeki imza şablonuna uymak zorundalar.
 */