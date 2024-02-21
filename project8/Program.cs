using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager person = new PersonManager();
            Customer customer = new Customer {id=1,
                Firstname="ece",
                Lastname="filiz",
                Adress="Ankara"};
            Student student = new Student { 
                Firstname = "mina",
            Lastname = "solmaz",
             id = 2,
              Department = "Computer Engineering"
            };
            Employee employee = new Employee { Firstname = "melike",
             Lastname = "soysal",
             id = 3, 
             Salary = "35000"};
            
            person.Add(student);
            person.Add(customer);
            person.Add(employee);
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int id { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }

    }
    class Customer : IPerson
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
    }

    class Employee : IPerson
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Salary { get; set; }
    }
    class PersonManager
    {
        //bu şekilde her class için ayrı fonk oluşturmaktansa direkt interfacei kullanabilirim.
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Firstname);
        }
        public void Add(Student student)
        {
            Console.WriteLine(student.id);
        }
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Firstname);

        }

    }
}
