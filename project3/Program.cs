using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ehliyet alıp almama
            /*
            Console.WriteLine("Kaç Yaşındasınız? ");
            int age = Convert.ToInt32(Console.ReadLine());                     
            Adult(age);
            
            ProgramLang();
            
            Questions();
            

            LogIn();
            

            Burclar();
            */
            //if else if else her şey tek satırda olacak
            InLineif();
            Console.ReadLine();
        }

        private static void InLineif()
        {
            Console.WriteLine("Lütfen sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool boolean = sayi % 3 == 0 ? true : false;
            string answer = boolean ? "3 ile bölünebilir! " : "3 ile bölünemez!";
            Console.WriteLine(answer);
            Console.WriteLine("Lütfen şehir adı giriniz: ");
            string input_country = Console.ReadLine();
            Console.Write("Plaka kodu: ");
            string country = input_country == "Ankara" ? "06" : input_country == "ankara" ? "06" : "0";
            Console.WriteLine(country);

            //kullanıcıdan 2 sayı isteyelim 

        }

        private static void Burclar()
        {
            Console.WriteLine("Ayın kaçında doğdunuz?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi ayda doğdunuz?");
            string month = (Console.ReadLine());
            if((month == "mayıs" && day >= 22) || (month == "haziran" && day<= 22))
            {
                Console.WriteLine("İkizler burcusunuz");
            }
            else
            {
                Console.WriteLine("ikizler burcu değilsiniz sevinin!");
            }
        }

        private static void LogIn()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();
            if (name == "ece" && password == "123456")
            {
                Console.WriteLine("Entry is succesful. ");
            }
            else
            {
                Console.WriteLine("Failed.");
            }
        }

        //sorulardan kaç tanesini bildi?
        private static void Questions()
        {
            int trueA = 0;
            int falseA = 0;
            Console.WriteLine("Türkiye'nin başkenti neresidir?");
            string answer1 = Console.ReadLine();
            if (answer1 == "ankara" || answer1 == "Ankara")
            {
                trueA++;
            }
            else
            {
                falseA++;
            }
            Console.WriteLine("Almanya hangi kıtadadır?");
            string answer2 = Console.ReadLine();
            if (answer2 == "avrupa" || answer2 == "Avrupa")
            {
                trueA++;
            }
            else
            {
                falseA++;
            }
            Console.WriteLine("Renkleri siyah beyaz olan takım hangisidir?");
            string answer3 = Console.ReadLine();
            if (answer3 == "beşiktaş" || answer3 == "Beşiktaş")
            {
                trueA++;
            }
            else
            {
                falseA++;
            }
            Console.WriteLine("Doğru cevap sayısı: " + trueA);
            Console.WriteLine("Yanlış cevap sayısı: " + falseA);
        }

        //string karşılaştırması
        private static void ProgramLang()
        {
            Console.WriteLine("Hangi programlama dilini seviyorsun? ");
            string answer = Console.ReadLine();
            if (answer == "c#" || answer == "C#")
            {
                Console.WriteLine("Harika!");
            }
            else if (answer == "ptyhon" || answer == "Python")
            {
                Console.WriteLine("easiest is the best!");
            }
            else
            {
                Console.WriteLine("okey nice!");
            }

        }

        //ehliyet alabilir mi? basit sorgulama
        public static void Adult(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Reşitsin, ehliyet alabilirsin.");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsın, yaşını bekle.");
            }
        }


    }
}
