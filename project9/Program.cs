using System;
using System.Collections.Generic;
using System.Linq; //usefull  for array methods
using System.Text;
using System.Threading.Tasks;

namespace project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person[] people = new Person[2]
            {
                new Customer
                {
                    FirstName = "Ece İrem",
                    City = "Ankara",
                    Id = 1,
                    LastName = "Şişer"
                },
         
                new Person
                {
                    FirstName = "Çiğdem",
                    LastName = "Şişer",
                    Id = 2,
                },
            };
            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            
            Console.ReadLine();

        }

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //interfaceleri birden fazla kez argüman olarak verebiliyoruz
    //Ancak bir class'ın sadece bir atası olabilir.
    //bu yüzden tek bir yerden kalıtım alıyor.
    class Customer : Person 
    {
        public string City { get; set; }

    }
    class Student : Person 
    {
        public string Department { get; set; }
    }
}
