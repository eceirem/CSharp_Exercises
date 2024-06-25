using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace w3schools

{
    internal class Program
    {

        static void Main(string[] args)
        {
            //MyMethod("Sweden");
            //MyMethod("India");
            //MyMethod();
            //Console.WriteLine(MyMethod2(5));
            //Console.WriteLine(MyMethod2());
            //int myNum = PlusMethod(2, 3);
            //double myNum2 = PlusMethod(4.3, 6.26);
            //Console.WriteLine("Int: " + myNum);
            //Console.WriteLine("Double: " + myNum2);
            //Car myObj = new Car();
            //Car myObj2 = new Car();
            //Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj2.color);
            //myObj.fullThorottle();
            //myObj.color = "black";
            //myObj.maxSpeed = 250;
            //Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj.maxSpeed);
            //Car Ford = new Car();
            //Ford.model = "Mustang";
            //Ford.color = "Red";
            //Ford.maxSpeed = 250;
            //Ford.year = 1969;

            //Car Opel = new Car();
            //Opel.model = "Astra";
            //Opel.color = "White";
            //Opel.maxSpeed = 200;
            //Opel.year = 2015;
            //Console.WriteLine(Ford);
            //Console.WriteLine(Opel);
            //Opel.fullThorottle();
            Car Volvo = new Car("XC60", 2022, 320, "Black");
            Console.WriteLine(Volvo);
            Volvo.honk();
            Person p1 = new Person();
            p1.Name = "Ece";
            Student student = new Student();
            student.Name = "Ece İrem";
            Console.WriteLine(student.Name);
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.animalSound();
            cat.sleep();
            dog.sleep();
            dog.animalSound();
            dog.run();
            Console.ReadKey();

        }
        static void MyMethod(string country = "Turkey")
        {
            Console.WriteLine("My country is " + country);
        }
        static int MyMethod2(int x = 2)
        {
            return x + 5;
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

    }

}
