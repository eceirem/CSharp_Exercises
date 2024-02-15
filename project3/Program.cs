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
            
            Console.WriteLine("Kaç Yaşındasınız? ");
            int age = Convert.ToInt32(Console.ReadLine());                     
            Adult(age);
            //hangi programlama dilini kullanıyor ona göre mesaj basalım
            ProgramLang();
            //counter ve string uygulaması. kaç soru doğru bildim, kaç soru bilemedim
            Questions();
            //and operatorü
            LogIn();
            //and ve or operatörü, ikizler misin değil misin
            Burclar();
            
            //if else if else her şey tek satırda olacak
            InLineif();            
            
            //kullanıcıdan 2 sayı isteyelim ve sayılar arası karşılaştırmayı inlineif kullanarak yapalım.
            compareNumbers();
            
            //kullanıcıdan 2 sayı al, çift sayı ise karesini; tek sayı ise küpünü al.
            Operation();
            
            //switch-case kullanımı 
            Console.BackgroundColor = ConsoleColor.Magenta;
            SwitchUsing();
            
            //beden kitle indeksi hesaplayıp kilo durumunu yazdırmak için switch-case kullanalım.
            bmi();
            Console.ReadLine();
        }

        private static void bmi()
        {
            Console.WriteLine("Please enter your height (cm): ");
            double height = Convert.ToInt32(Console.ReadLine());
            height = height / 100;
            Console.WriteLine("Please enter your kilo: ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your gender: (f/m)");
            string gender = Console.ReadLine();
            double index = kilo / (height * height);
            switch (gender)
            {
                case "f":
                    if (index < 19) {
                        Console.WriteLine("Olması gerekenden zayıfsınız hanımefendi, diyetisyene başvurun ve kas kütlenizi arttıracak egzersizler yapın.");
                    }
                    else if (index >= 19 && index <=24){
                        Console.WriteLine("Olması gereken kilodasınız hanımefendi. Bunu koruyun!");
                    }
                    else
                    {
                        Console.WriteLine("Olması gerekenden kilolusunuz hanımefendi, diyetisyene başvurun ve kas kütlenizi arttıracak egzersizler yapın.");

                    }
                    break;

                case "m":
                    Console.WriteLine(index < 20 ? "Zayıf" : index < 25 ? "İdeal Kilo" : "Fazla kilo");
                    break;

                default:
                    Console.WriteLine("Geçerli bir cinsiyet giriniz.");
                    break;

            }

        }

        private static void SwitchUsing()
        {
            //fazla eşitlik kullanıyorsak switch kullanırız.
            ConsoleColor renk = Console.BackgroundColor;
            switch (renk)
            {
                case ConsoleColor.Black:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case ConsoleColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
        }

        private static void Operation()
        {
            Console.WriteLine("Lütfen sayı giriniz: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Bu sayı çifttir. Bu yüzden karesi alınacak: " + Math.Pow(num, 2));
            }
            else
            {
                Console.WriteLine("Bu sayı tektir. Bu yüzden küpü alınacak: " + Math.Pow(num, 3));
            }
        }

        private static void compareNumbers()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string result = num1 > num2 ? "1. sayı daha büyük" : num1 < num2 ? "2. sayı daha büyük" : "iki sayı eşit";
            Console.WriteLine(result);
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
