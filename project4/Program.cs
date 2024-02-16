using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methodlar (bütün fonksiyonlar methoddur) ve return parametreleri
            
            myMethod();
            string myStr = Program.ReadValue();
            Console.WriteLine(myStr);
            int num = Program.Number();
            Console.WriteLine(num);
            
            //kullanıcıdan 2 sayı isteyip ortalamasını ekrana yazdıran program
            int num1 = enterNumber();
            int num2 = enterNumber();
            int num3 = (num1 + num2) / 2;
            Console.WriteLine(num3);
            
            //kullanıcıya oğduğu yılı soracak ve yaşını bulacak. Reşit mi onu bulaacak.
            //kullanıcının yaşını bulup rakamları toplamını yazdıran program

            int year = Year();
            Console.WriteLine(year);
            bool adult = Adult();
            Console.WriteLine("Adault: " + adult);
            
            
            
            addNum();
            int number = addNum();
            Console.WriteLine(number + "yaşının rakamları toplamı");
            pageColour();
            
            //tarih ve zaman kullanımları
             dateTime();
            dateTimeDiff();
            
            //mezuniyet tarihi ile bugün arasında kaç gün olduğunu bulan method
            HowManyDayToGraduate();
          
            HowManyMinToGo(); 
            
            //kullanıcının doğum tarihini alalım, 
            //doğduğu gün haftanın hangi günü?
            //şimdiye kadar kaç gün yaşamış?
            LifeTime();

            Console.ReadKey();

        }

        private static void LifeTime()
        {
            Console.WriteLine("When did you born? ");
            DateTime bornDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(bornDate.DayOfWeek);
            int day_diff = (int) (DateTime.Today - bornDate).TotalDays;
            Console.WriteLine(day_diff);
            int year = day_diff / 365;
            Console.WriteLine(year);
        }

        private static void HowManyMinToGo()
        {
            var now = DateTime.Now;
            //exit ve exit2 aynı
            var exit = Convert.ToDateTime("2024-02-16 19:00:00");
            var exit2 = new DateTime(2024, 02, 16, 19, 0, 0);
            TimeSpan time = exit - now;
            Console.WriteLine("Toplam " + time.TotalMinutes + " min");
            Console.WriteLine("To exit " + time.Hours + "h " + time.Minutes + "min remains");
        }

        private static void HowManyDayToGraduate()
        {
            DateTime graduate = new DateTime(2026, 07, 10);
            TimeSpan remainingTime = graduate - DateTime.Today;
            Console.WriteLine(remainingTime);
            Console.WriteLine(remainingTime.TotalDays);


        }

        private static void dateTimeDiff()
        {
            DateTime time = Convert.ToDateTime("2019-01-01"); //veritabanında yıl ay gün şeklinde tutulur.
            Console.WriteLine(time);
            DateTime graduate = new DateTime(2026, 06, 20);
            Console.WriteLine("Year's " +graduate.DayOfYear + "th day");
            Console.WriteLine("Weak's " + graduate.DayOfWeek);

        }

        private static void dateTime()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString("MM/dd/yyyy dd MMMMM -ece hh:mm HH:mm"));


        }

        private static int addNum()
        {
            int age = Age();
            Console.WriteLine("Yasiniz " + age + " idir.");
            int num1 = age / 10; //onlar basamağı
            int num2 = age % 10; //birler basamağı
            return num1 + num2;
        }

        private static void pageColour()
        {
            if (addNum() % 2 == 0 || Adult())
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();

            }
        }

        private static bool Adult()
        {
            return Age() >= 18;
        }

        private static int Age()
        {

            return DateTime.Now.Year - Program.Year();
        }

        private static int Year()
        {
            Console.WriteLine("Please enter your born year: ");
            return Convert.ToInt32(Console.ReadLine());

        }

        private static int enterNumber()
        {
            return Convert.ToInt32(Console.ReadLine());

        }

        private static int Number()
        {
            return Convert.ToInt32(Console.ReadLine());

        }

        private static string ReadValue()
        {
            return Console.ReadLine();
        }
         
        private static void myMethod()
        {
            Console.WriteLine("Hello");
        }
    }
}
