using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Console.ReadLine();

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
