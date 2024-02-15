using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bu derste cmd yazacak yazının arka planı ve konumlandırması var.
namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ece";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.CursorSize = 60;
            Console.CursorLeft = 30;
            Console.CursorTop = 10;
            Console.WriteLine("Deneme");
            Console.ReadKey();
        }
    }
}
