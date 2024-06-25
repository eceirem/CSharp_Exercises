using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace w3schools

{
    interface IAnimal
    {
        void run();
    }
    abstract class Animal
    {
        public abstract void animalSound();
        public abstract void sleep();
    }
    class Dog : Animal, IAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
        public override void sleep()
        {
            Console.WriteLine("zzz,pfff");
        }
        public void run()
        {
            Console.WriteLine("dogs run!!");
        }

    }
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: meow meow");
        }
        public override void sleep()
        {
            Console.WriteLine("zzz,meow");
        }
    }

    class Vehicle //base class
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut");
        }
    }
    class Car : Vehicle
    {
        string color, model;
        int maxSpeed, year;
        public Car(string modelName, int carYear, int limitSpeed, string carColor)
        {
            model = modelName;
            year = carYear;
            maxSpeed = limitSpeed;
            color = carColor;
        }

        public void fullThorottle()
        {
            Console.WriteLine($"{model} is going as fast as it can!");
        }

        public override string ToString()
        {
            return $"Yıl: {year}, Model: {model}, Max Hız: {maxSpeed}, Renk: {color}";
        }

    }
    class Person
    {
        private string name; //field
        public string Name
        {
            get { return name; } //get method
            set { name = value; } //set method
        }
    }
    class Student : Person
    {
        private string Name
        { set; get; }
    }
}
