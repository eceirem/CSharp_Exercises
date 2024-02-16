using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Loglama();
            //try-catch
            try
            {
                int note = Convert.ToInt32(Console.ReadLine());
                string mesaage = note >= 80 ? "very well!" : note <= 50 ? "failure" : "not bad";
                Console.WriteLine(mesaage);
            }
            catch
            {
                Console.WriteLine("Unexpected input.");
                throw new Exception("Invalid syntax!");
            }
            
            Method();

            Console.ReadKey();

        }

        private static void Method()
        {
            try
            {
                Console.WriteLine("How many people will share 500 balls");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    throw new DivideByZeroException();
                }
                double ball = 500.0 / num;
                Console.WriteLine(ball + " ball(s) have each person.");
            }
            catch(DivideByZeroException er)
            {
                Console.WriteLine("Divide by zero error.");
            }
            catch(FormatException err)
            {
                Console.WriteLine("Invalid input. Just numbers!");
            }
            catch (Exception err)
            {
                Console.WriteLine("Another error!");
            }
        }

        private static void Loglama()
        {
            try{
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num == 3)
                {
                    throw new Exception("this is not avaliable number.");
                }
            }
            catch (Exception error) {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", error.Message);
                File.AppendAllText("log.txt", error.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine + "******************************"+ Environment.NewLine);
            }


        }
    }
}
