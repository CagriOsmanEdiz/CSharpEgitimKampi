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

        Console.WriteLine("***** Fiyat Listesi *****");
        Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 35.50;
            potatoPrice = 12.50;
            tomatoPrice = 18.75;
            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "TL");
            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "TL");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 3.500;

            double appleTotalPrice =appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Toplam Tutar: " + totalPrice);

            #endregion
        }
    }
}
