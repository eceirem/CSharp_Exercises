using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CustomerManager ece = new CustomerManager();
            ece.add();
            ece.update();
            ece.List();
            Product canan = new Product(1,"pc");           
            Product urun = new Product(2, "Laptop");
            urun.Hoba();
            Customer doğukan = new Customer();
            doğukan.City = "Ankara";
            doğukan.id = 2;
            doğukan.Name = "Doğukan";
            doğukan.Surname = "Filiz";
            Customer mina = new Customer
            {
                id = 1,
                City = "İstanbul",
                Name = "Mina Su",
                Surname = "Yılmaz"

            };
            
            Console.WriteLine(mina.Name);
            Console.WriteLine(doğukan.id);
            Console.WriteLine(mina);
            
            EmployerManager emp = new EmployerManager(new FileLogger());
            //artık bu ifadeye gerek yok -> emp.logger = new FileLogger();
            
            emp.Add();
            PersonManager canan = new PersonManager("Ece");*/
            //Teacher can = new Teacher(); // bu şekilde ifade edemem
                                         // çünkü static demek bellekte oluşmuş demek
                                         //bellekte oluşmuş bir şeyi yeniden oluşturamazsınız.

            Teacher.Number = 15;
            //normal bir class altındaki static ve normal method nasıl çağrılır?
            Manager.DoSomething();//direkt kullanılabilir.
            Manager can = new Manager();
            can.DoSomething2();

            Console.ReadLine();
        }

    }
    class Product
    {
        public string Name { get; set; }
        public int id { get; set; }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id + 5;
            _name = name + "ece";
        }

        public void Hoba()
        {
            Console.WriteLine(_id + _name);

        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }
    class EmployerManager
    {
        private ILogger _logger;
        public EmployerManager(ILogger canan)
        {
            _logger = canan;
        }
        //public ILogger logger { get; set; }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
    class Baseclass
    {
        private string _entity;
        public Baseclass(string ece)
        {
            _entity = ece;
        }
        public void Message()
        {
            Console.WriteLine("{0} mesaage", _entity);
        }
    }

    class PersonManager : Baseclass
    {
        public PersonManager(string hoba):base(hoba)
        {
            //bir person oluşturduğumda otomatik olarak buraya gelecek.
            //ama message Add içerisinde olsaydı onu çağırmam gerekirdi.

            Message();

        }
        public void Add()
        {
            Console.WriteLine("Added.");
        }
    }

    static class Teacher
    {
        //static class'ın her şeyi static olmak zorundadır.
        public static int Number { get; set; }
        //statik class'ın constructer'ı public olamaz!
        //public Teacher()
        static Teacher()
        {
            
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done.");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2.");
        }
    }
   
}
