using System;

namespace oop_vize_codes
{
    interface IEmployee
    {
        void showDetail();
    }
    class Employee : IEmployee
    {
        public string name;
        
        public Employee (string n)
        {
            name = n;
        }
        public virtual void showDetail()
        {
            Console.WriteLine(name);
        }
    }
    class Engineer : Employee
    {
        public int dnumber;
        public Engineer(string  n, int d) : base(n) 
        {
            
            dnumber = d;
        }
        public override void showDetail()
        {           
            Console.WriteLine(name+" "+dnumber);
        }
    }
    class Person
    {
        public string name; 
        public Person(String  n) { name = n; }
        public override string ToString()
        {
            return "Hello, my name is " + name ;
        }
        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(obj.GetType() != typeof(Person)) return false;
            Person p = (Person) obj;
            return name.Equals(p.name);
        }

    }
    class Student : Person
    {
        int Id;
        public Student(string n, int id) : base(n)
        {
            this.Id = id;
        }
        public override string ToString()
        {
            return base.ToString() + " and my id is" + this.Id;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[4];

            person[0] = new Person("Ece");
            person[1] = new Person("İrem");
            person[2] = new Person("Çiğdem");
            person[3] = new Person("Önder");
            foreach (Person p in person)
            {
                Console.WriteLine(p.name);
            }

            Person[,] persons = new Person[2, 2];
            Console.WriteLine("2x2lik matriste bakalım: ");
            persons[0,0] = new Person("Ece") ;
            persons[0,1] = new Person("İrem") ;
            persons[1,0] = new Person("Çiğdem") ;
            persons[1,1] = new Person("Önder");

            for (int i = 0; i < persons.GetLength(0); i++)
            {
                for (int j = 0; j < persons.GetLength(1); j++)
                {
                    Console.Write(persons[i, j].name);
                }
                Console.WriteLine();
            }
            Employee ee = new Engineer("Ayşe", 1); ee.showDetail();
            IEmployee ie = new Engineer("Ali", 2); ie.showDetail();

            Person prs = new Person("Çiğdem");
            Console.WriteLine(prs);
            Student std = new Student("Ece", 22290727);
            Console.WriteLine(std);


            Console.ReadLine();
        }
    }
}
