using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Program
    {
        //arrays-strings-for-while-break-continue(loops)
        static void Main(string[] args)
        {
            
            
            string[] names = { "Ali", "Can", "Ece", "Çiğdem" };
            int[] numbers = { 1, 2, 3, 4,5,6};
            char[] characters = { 'a', 'b', 'c','d','e' };
            Console.WriteLine(numbers[3]);
            Console.WriteLine(characters[3]);
            Console.WriteLine(names[3]);
            //tarihi bölmek
            dateSplit();
            //dosya yollarına erişmek ve en sondaki dosyayı \ split ederek bulmak
            filesProcess();
            //listedeki soruları sırayla sorup cevaplarını kontrol edip kaç doğru kaç yanlış var hesaplayan fonk.
            QuesList();
            //öğrenci adını string olarak alacak ama 3 koşulu olacak:
            // 1-en az 3 karakter girin 
            // 2-boş bırakmayın
            // 3-teşekkürler
            studentRecord();
            //nullable nedir? 
            //string bir class olduğu için null olabilir.
            //int ve double struct olduklarından null olamazlar. onları null yapmak için bullable kullanırız.
            
            Nullable<int> number = null;
            int? emptyNum = null;
            DateTime date = new DateTime();
            Console.WriteLine(number);
            Console.WriteLine(emptyNum);
            Console.WriteLine(date);
            
            //for dögüsüne geçiş
            //5 adet isim olsun dizide ve bastırın
            string[] names = { "Ece", "İrem", "Mina", "Doğukan", "Poyraz" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hello " + names[i]+" is my name.");
            }            
            //while döngüsü
            
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            
            //do-while
            int i = 0;
            do { Console.WriteLine("Please enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i);
                i++;  
            } 
            while (i < 3);
            //do-while sorusu, kullanıcıya şifre soralım
            //bilene kadar sormaya devam edelim
            //bilirse teşekkürler yazsın
            int password = 1234;
            int input = 0;

            do
            {
                Console.WriteLine("Incorrect password! " +
                    "Please try again!");
                input = Convert.ToInt32(Console.ReadLine());

            }
            while (input != password);
            Console.WriteLine("Thanks!");
           
            //foreach
            //Dolaşmak istediğiniz döngüyü yazıyorsunuz!
            string[] countries = { "Turkey", "Germany", "France" };
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            int[] numbers = { 5, 9, 15, 17};
            foreach(int number in numbers)
            {
                Console.WriteLine((number - 1) * 3);
            } 
            
            //dizi olsun
            //buradaki en büyük negatif sayıyı 
            //en küçük pozitif sayıyı ekrana yazdıralım
            int[] numbers = { 19, 45, -247, 212, -134, 319, -78 };
            
            int maxnum = 0;
            int minnum = 0; 
            foreach (int n in numbers)
            {
                if (n > maxnum)
                {
                    maxnum = n;
                }
                else if(n < minnum)
                {
                    minnum = n;
                }
            }
            int maxNnum = minnum;
            int minPnum = maxnum;
            Console.WriteLine("Max number is: " + maxnum);
            Console.WriteLine("Min number is: " + minnum);
            //en küçük pozitif sayıyı bulabilmek için en büyük değeri atarım
            //ondan küçük gelen her değeri yeni max yaparak güncellerim
            
            foreach (int n in numbers)
            {
                if (n > 0 && n < minPnum)//burada n < maxnum deseydim 212 en son gelen poztif sayı olduğundan bu kalıcı değer olurdu.
                {
                    minPnum = n;
                }
                else if (n < 0 && n > maxNnum)
                {
                    maxNnum = n;
                }
            }
            Console.WriteLine("Max negative number is: " + maxNnum);
            Console.WriteLine("Min positive number is: " + minPnum);
            
            //kullanıcının 05321234567 numarasını
            //0532 123 45 67 formatına çeviren programı yazın
            string phoneNum = "05321234567";
            string phoneNumNew = "";
            for (int i = 0; i < phoneNum.Length; i++) {
                if(i==4 || i==7 || i == 9)
                {
                    phoneNumNew += " ";
                    phoneNumNew += phoneNum[i]; //bunu unutma yoksa 1,4,6 değerlerini eklemez.

                }
                else
                {
                    phoneNumNew += phoneNum[i];
                }
            }
            int i = 0;
            string phoneNum = "05321234567";
            string phoneNumNew = "";
            foreach (var num in phoneNum)
            {
                if (i == 4 || i == 7 || i == 9)
                {
                    phoneNumNew += " ";
                    phoneNumNew += num;
                    
                }
                else
                {
                    phoneNumNew += num;

                }
                i++;

            }
            Console.WriteLine(phoneNumNew);
            //kullanıcıdan bir sayı isteyin
            //sayının faktöriyelini ekrana yazdırın
            Console.WriteLine("Please enter a number to calculate" +
                "the factorial of number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i < num+1; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial: " + fact);


            //ascii
            for (int i = 65; i < 91; i++)
            {
                Console.WriteLine((char)i);
            }
            for (int i = 0; i <= 8; i++) {
                for(int j = 0;j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            //asal sayı mı programı 1 ve 0 girilince hata mesajı verdir.
            //1-50 arasında kaç tane asal sayı vardır?
            int counter = 0;
            for(int i = 2; i <= 50; i++) {
                if (Program.isPrime(i))
                {
                    counter++;
                }
            }
            Console.WriteLine("Prime number count between 1-50 is: "+counter);
            
            RandomThings();
            Console.ReadLine();

        }

        private static void RandomThings()
        {
            Random r = new Random();
            int num = r.Next(10);//her seferinde yeni bir sayı atamak için next deriz
                               //içerisine yazdığım argümana kadar olan sayılardan random sayı üretir.
            for (int i = 0; i < 10; i++){                
                Console.WriteLine(num);
                num = r.Next(10);
            }
            string[] countries = { "İstanbul", "Ankara", "İzmir" };
            int index = r.Next(3);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(countries[index]);
                index = r.Next(3);
            }

            }

            private static bool isPrime(int input)
        {
            int num = input;
            bool isprime = true;
            if(num==1 || num==0)
            throw new Exception("We cannot check primety for these numbers: 0 and 1. Please enter another number!");
            for(int i = 2; i < num; i++) {
                
                if (num % i == 0)
                {
                    isprime = false;
                }
            }
            return isprime;

        }


        private static void studentRecord()
        {
            Console.WriteLine("Please enter the name-surname: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name.Trim())) //Trim aradaki boşlukları kaldırır.
            {
                Console.WriteLine("Please enter a name.");
            }
            else if(name.Length < 3) {
                Console.WriteLine("You should enter a name more than 3 characters.");
            }
            else
            {
                Console.WriteLine("Thanks!");
            }
        }

        private static void QuesList()
        {
            int trues = 0;
            int falses = 0;
            string[] questions = { "Where is Finland?", "Which country is famous for its bananas?", "What is the answer of that math: 7*8" };
            string[] answers = new string[3];
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                answers[i] = Console.ReadLine();
            }
            if (answers[0] == "Europe") 
            {
                trues++;
            }
            else
            {
                falses++;
            }
            if (answers[1] == "India")
            {
                trues++;
            }
            else
            {
                falses++;
            }
            if (answers[2] == "56")
            {
                trues++;
            }
            else
            {
                falses++;
            }
            Console.WriteLine("True Answers: " + trues);
            Console.WriteLine("Wrong Answers: " + falses);


        }

        private static void filesProcess()
        {
            string[] files = Directory.GetFiles(@"C:\ece\coding\codes\C#\CSharp_Exercises\project6");
            Console.WriteLine("In this folder we have " +  files.Length + " files");
            Console.WriteLine("The first file is " + files[0]);
            string[] strs = files[0].Split('\\');
            Console.WriteLine(strs[strs.Length-1]);
        }

        private static void dateSplit()
        {
            string date = "29.11.2018";
            string[] strings = date.Split('.');
            Console.WriteLine(strings[strings.Length-1]);
        }
    }
}
