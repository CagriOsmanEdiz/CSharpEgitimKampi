using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Burada double numaraları nokta ile ayırırken konsolda sayı ekranda virgül ile ayrılmış şekilde gösterilir

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //    double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //    applePrice = 14.85;
            //    orangePrice = 20.95;
            //    strawberryPrice = 35.50;
            //    potatoPrice = 12.50;
            //    tomatoPrice = 18.75;
            //    Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "TL");
            //    Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //    Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //    Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //    Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");
            //    Console.WriteLine();

            //    double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //    appleGram = 1.245;
            //    orangeGram = 2.650;
            //    strawberryGram = 0.750;
            //    potatoGram = 3.500;

            //    double appleTotalPrice =appleGram * applePrice;
            //    double orangeTotalPrice = orangeGram * orangePrice;
            //    double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //    double potatoTotalPrice = potatoGram * potatoPrice;
            //    double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice;

            //    Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Toplam Tutar: " + appleTotalPrice);
            //    Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Toplam Tutar: " + orangeTotalPrice);
            //    Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Toplam Tutar: " + strawberryTotalPrice);
            //    Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Toplam Tutar: " + potatoTotalPrice);
            //    Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Toplam Tutar: " + totalPrice);

            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //Caesar Cipher = A+3=4 B+3=5 C+3=6 D+3=7 E+3=8 F+3=9 G+3=10 H+3= 11
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);
            //Char karakterlere atama yapılırken tek tırnak kullanılır.
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //    Console.WriteLine("***** ^ C# Hava Yolları Yolcu Bilgi Sistemi ^ *****");
            //    Console.WriteLine();

            //    string passangerName, passangerSurname, passangerGender, passangerPhoneNumber,passangerEmail;
            //Console.WriteLine("***** Yolcu Bilgi Sistemi *****"); 
            //    Console.WriteLine();
            //    Console.WriteLine("Hoşgeldiniz! Lütfen adınızı giriniz: ");
            //passangerName = Console.ReadLine();
            //Console.WriteLine("Lütfen soyadınızı giriniz: ");
            //passangerSurname = Console.ReadLine();
            //Console.WriteLine("Lütfen cinsiyetinizi giriniz: ");
            //passangerGender = Console.ReadLine();
            //Console.WriteLine("Lütfen telefon numaranızı giriniz: ");
            //passangerPhoneNumber = Console.ReadLine();
            //Console.WriteLine("Lütfen email adresinizi giriniz: ");
            //passangerEmail = Console.ReadLine();
            //Console.WriteLine();
            //    Console.WriteLine("Sayın "+passangerName+" "+passangerSurname+" C# Hava Yolları Güzel Bir Uçuş Diler");

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //Klavyeden alınan her bir veri string olarak alınır. Bu nedenle tam sayı gibi farklı veri tiplerine dönüştürülmesi gerekir.


            //    int shoePrice, computerPrice, chairPrice, tvPrice;
            //    shoePrice = 1000;
            //    computerPrice = 20000;
            //    chairPrice = 5000;
            //    tvPrice = 12000;
            //    int shoeCount, computerCount, chairCount, tvCount;
            //    Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //    shoeCount= int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //    computerCount=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Lüffen aldığınız sandalye sayısını giriniz: ");
            //    chairCount=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //    tvCount=int.Parse(Console.ReadLine());

            //    int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            //    Console.WriteLine("Eğer detaylı bir fatura istiyorsanız 1,toplam tutarı öğrenmek istiyorsanız 0'a basınız.");
            //   int passengerChoice = int.Parse(Console.ReadLine());
            //    if(passengerChoice == 1)
            //    {
            //        Console.WriteLine("Alınan Ürün: Ayakkabı - " + "Birim Fiyat: " + shoePrice + " - Toplam Tutar: " + (shoePrice * shoeCount));
            //        Console.WriteLine("Alınan Ürün: Bilgisayar - " + "Birim Fiyat: " + computerPrice + " - Toplam Tutar: " + (computerPrice * computerCount));
            //        Console.WriteLine("Alınan Ürün: Sandalye - " + "Birim Fiyat: " + chairPrice + " - Toplam Tutar: " + (chairPrice * chairCount));
            //        Console.WriteLine("Alınan Ürün: Televizyon - " + "Birim Fiyat: " + tvPrice + " - Toplam Tutar: " + (tvPrice * tvCount));
            //    }
            //    else {
            //        Console.WriteLine("Satın almış olduğunuz tüm ürünler için ödemiş olduğunuz fiyat: " + totalPrice);
            //    }


            //    //int.Parse() metodu ile Convert.ToInt32() arasındaki fark int.Parse() metodu null değer ile karşılaştığında hata verir ve sadece string değerleri dönüştürür Convert.ToInt32() metodu ise null değer ile karşılaştığında 0 döner ve Convert.ToInt32() metodu  farklı veri tiplerini de dönüştürebilir.            

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3,result;
            //Console.WriteLine("Lütfen birinci sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen üçüncü sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result= (exam1+exam2+exam3)/3;
            //Console.WriteLine("Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;

            //Console.WriteLine("Lütfen cinsiyetinizi giriniz (E/K): ");
            //gender = char.Parse(Console.ReadLine());
            //// char.Parse kullanılmasının sebebi klavyeden veri girişinin string olarak alınması ve char türünün sadece bir karakter kabul etmesidir.
            //Console.WriteLine("Cinsiyetiniz: " + gender);
            //if(gender == 'E' || gender == 'e')
            //{
            //    Console.WriteLine("Erkek");
            //}
            //else if(gender == 'K' || gender == 'k')
            //{
            //    Console.WriteLine("Kadın");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş");
            //}

            #endregion
            //a

        }
    }
}
