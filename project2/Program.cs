using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//başlangıç dersleri
namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            //tip değiştirme ve atamalar.
            string str = "78";
            int convert = Convert.ToInt32(str);
            Console.WriteLine(convert);
            var val = Console.ReadLine();
            int num = Convert.ToInt32(val);
            Console.WriteLine(num);
            Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
            var str2 = Console.ReadLine();
            int age = Convert.ToInt32(str2);
            age -= 5;
            Console.WriteLine(age +" yaşında gösteriyorsunuz.");
            //kaç lira alışveriş yaptın?
            //100
            //%10 indirim olsun
            //kaç lira indrim kazandığımım göstersin
            Console.WriteLine("Kaç Lira Alışveriş Yaptınız? Lütfen Giriniz: ");
            var str3  = Console.ReadLine();
            int cost = Convert.ToInt32(str3);
            Console.WriteLine("Yüzde Kaç İndirim Var? Lütfen Giriniz: ");
            var str4 = Console.ReadLine();
            int salePercent = Convert.ToInt32(str4);
            int saleCost = cost * salePercent / 100;
            Console.WriteLine(saleCost + " Lira İndirim Kazandınız.");
            //ms cinsinden olan bu değeri dakika olarak ekrana yazdırın.
            var ms = Environment.TickCount;
            var s = ms / 1000;
            var d = s / 60;
            var saat = d / 60;
            Console.WriteLine(saat + " saat.");
            //Gün-Ay-Yıl yazdırmak DateTime sınıfından alınır
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int day = DateTime.Today.Day + 1; //ertesi günü yazdır.
            Console.WriteLine(day + "." + month + "." + year);
            Console.WriteLine("Lütfen 1-5 arasında bir değer giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double pi = Math.PI;
            var piInt = Convert.ToInt32(pi);
            int mux = piInt * number;
            Console.WriteLine(mux);            
            //sayılarda işlemler 
            float value = 9;
            Console.WriteLine("Sayı: " + value);
            Console.WriteLine("Sayının karesi: " + value*value);
            Console.WriteLine("Sayının ikiye bölümü: " + value / 2);
            Console.WriteLine("Sayının ikiyle bölümünden kalanı: " + value%2);
           
            // bool Boolean : true veya false değerini alır.
            bool onerme = 5 > 3;
            bool onerme2 = 5 < 1;
            bool onerme3 = (8 == 8);
            Console.WriteLine(onerme);
            Console.WriteLine(onerme2);
            Console.WriteLine(onerme3); 
            //kullanıcının yaşını alıp reşit olup olmadığını belirlemek
            Console.WriteLine("Yaşınızı Giriniz: ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool resit = age >= 18;
            Console.WriteLine(resit);       
            //directory sınıfının exists metoduna test pararmetesini gönderelim. amaç kütüphane yoksa onu önerdiğini görmek ve hata ayıklada üzerine bastoğımızda otomatik ekliyor.
            bool exists = Directory.Exists("test");
            Console.ReadKey();

        }
    }
}
