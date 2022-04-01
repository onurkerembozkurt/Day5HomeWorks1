using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person[] persons = new Person[2]{ 
                new Customer {FirstName="Derin" },
                new Student{FirstName="Salih"} 
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Departmant { get; set; }
        }
    }
}
//Yanlızca bir classdan inheritance alınabilir fakat Interfacelerde öyle bi kural yoktur
//İlk inheritance yazılır sonra interface yazılır.
