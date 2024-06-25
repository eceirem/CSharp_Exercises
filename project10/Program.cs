using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer ser = new SqlServer();
            ser.Add();
            ser.Delete();
            Mysql mysql = new Mysql();
            mysql.Add();
            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var item in cities)
            {
                Console.WriteLine(item);

            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Ece", LastName = "Şişer" });
            customers.Add(new Customer { Id = 3, FirstName = "Çiğdem", LastName = "Şişer" });
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Ece", LastName = "Şişer"},
                new Customer { Id = 3, FirstName = "Çiğdem", LastName = "Şişer" }
            };
            foreach (var person in customers)
            {
                Console.WriteLine(person.FirstName);
            }
            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Önder",
                LastName = "Şişer"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 8, LastName = "Yılmaz", FirstName = "Merve" },
                new Customer { Id = 10, LastName = "Yıldız", FirstName = "Şevval" }

            });
            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);
            foreach (var person in customers)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default.");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default.");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added to Sql Server");
        }
        public override void Delete()
        {
            Console.WriteLine("Deleted from Sql Server");
        }
    }
    class Mysql : Database
    {

    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default"); ;
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted from Sql Server");

        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted from Oracle");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
