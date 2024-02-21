using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            
            foreach (var worker in workers)
            {
                worker.Work();

            }
            IEat[] eaters = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach(var eater  in eaters)
            {
                eater.Eat();
            }
            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
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
                Console.WriteLine("You eat so much.");
            }

            public void GetSalary()
            {
                Console.WriteLine("You want so much.");
            }

            public void Work()
            {
                Console.WriteLine("You worked easy. Behave yourself!");
            }
        }
        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("You eat so much.");

            }

            public void GetSalary()
            {
                Console.WriteLine("You earn money.");

            }

            public void Work()
            {
                Console.WriteLine("You worked hard. Congrats!");

            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Good job.");

            }
        }
    }
}
