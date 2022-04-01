using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IWorker[] workers = new IWorker[2];
            {
                new Manager(),
                new Robot()

            };
        }
        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : IWorker
        {

            //Robotta Yemek yeme ve Çalışma Geçerli Degil  O yüzden şimdi interfacelerin 
            //güzel bi özelliğine geçiyoruz
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
