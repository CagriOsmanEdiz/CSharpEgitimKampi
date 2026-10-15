using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Bir komutun yanında mor bir küçük bir kutucuk var. Bu kutucuk, bu komutun bir metod olduğunu gösterir.
            //Console.Write("Merhaba Dünya");Console.Write() komutu ile ekrana yazdırma işlemi yapılır.Yazıyı alt satıra geçirmeden ekrana yazdırır.
            //Console.WriteLine("Selam");Console.WriteLine() komutu ile ekrana yazdırma işlemi yapılır.Yazıyı alt satıra geçerek ekrana yazdırır.

            //    Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar ");
            //Console.WriteLine("6- İçecekler ");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region StringDeğişkenler
            //Veriler üzerinde işlem yapılmasına yardımcı olan ve geçici olarak RAM'de saklanan alanlara değişken denir. Değişkenler, programın çalışması sırasında değerlerini değiştirebilirler. Değişkenler, belirli bir veri tipine sahiptir ve bu veri tipine uygun değerler alabilirler
            //string
            //Değişken_türü değişken_adı = değer;
            //string customerName;
            //string customerSurname;
            //string customerPhone; 
            //string customerEmail, district, city;

            //customerName = "Çağrı";
            //customerSurname = "Ediz";
            //customerPhone = "0555 555 55 55";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Müşteri Bilgileri *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri Adı: " + customerName);
            //Console.WriteLine("Müşteri Soyadı: " + customerSurname);    
            //Console.WriteLine("Müşteri Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri E-Posta: " + customerEmail);
            //Console.WriteLine("Müşteri Adresi: " + city + "/" + district);
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
            //customerName = "Ahmet";
            //customerSurname = "Kelel";
            //customerPhone = "0544 444 44 44";
            //customerEmail = "test@gmail.com";
            //district = "Beşiktaş";
            //city = "İstanbul";
            //Console.WriteLine("Müşteri Adı: " + customerName);
            //Console.WriteLine("Müşteri Soyadı: " + customerSurname);
            //Console.WriteLine("Müşteri Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri E-Posta: " + customerEmail);
            //Console.WriteLine("Müşteri Adresi: " + city + "/" + district);
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            #endregion

            #region Integer Değişkenler
            //int
            //int number = 19;
            //Console.WriteLine("Sayı: " + number);
             
            int hamburgerPrice = 300;
            int pizzaPrice = 400;
            int saladPrice = 200;
            int cokePrice = 90;
            int dessertPrice = 150;
            int lemonadePrice = 120;
            Console.WriteLine("***** Restoran Menü Fiyatları: *****");
            Console.WriteLine();
            Console.WriteLine("---- Kola: " + cokePrice + " TL");
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Salata: " + saladPrice + " TL");
            Console.WriteLine("---- Tatlı: " + dessertPrice + " TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatları: *****");
            Console.WriteLine();


            


            int hamburgerCount = 2;
            int pizzaCount = 1;
            int saladCount = 1;
            int dessertCount = 1;
            int cokeCount = 2;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalSaladPrice = saladPrice * saladCount;
            int totalDessertPrice = dessertPrice * dessertCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalSaladPrice + totalDessertPrice + totalCokePrice;


            Console.WriteLine("***** Restoran Sipariş Özeti: *****");
            Console.WriteLine(hamburgerCount + " tane hamburger yediniz");
            Console.WriteLine(pizzaCount + " tane pizza yediniz"); 
            Console.WriteLine(saladCount + " tane salata yediniz");
            Console.WriteLine(dessertCount + " tane tatlı yediniz");
            Console.WriteLine(cokeCount + " tane içecek içtiniz");
            //Console.WriteLine("Toplam Tutar: "+(hamburgerCount*hamburgerPrice + pizzaCount*pizzaPrice + saladCount*saladPrice + dessertCount*dessertPrice + cokeCount*cokePrice));
            Console.WriteLine("Toplam Tutar: "+totalPrice);



            #endregion








        }
    }
}
