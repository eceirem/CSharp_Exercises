using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer
                {
                    FirstName = "Ece",
                    City = "Ankara",
                    Id = 1,
                    LastName = "Filiz"
                },
                new Student
                {
                    FirstName = "Doğukan",
                    Id = 2,
                    LastName = "Filiz",
                    Department = "Computer Engineering"
                },
                new Person
                {
                    FirstName = "Çiğdem",
                    LastName = "Şişer",
                    Id = 3,
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
