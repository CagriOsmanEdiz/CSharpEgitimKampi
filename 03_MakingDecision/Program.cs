using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IfElse
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password =Console.ReadLine();
            //if(password =="abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");

            //}

            //        int number;
            //        Console.Write("Lütfen bir sayı giriniz: ");
            //        number = int.Parse(Console.ReadLine());
            //        if(number == 5)
            //        {
            //            Console.WriteLine("Sayı 5'e eşittir");
            //        }
            //        else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("Sınav 1 notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average >= 50)
            //{
            //    result = "Başarılı";
            //}
            //else if (average < 50 & average >= 40)
            //{
            //    result = "Bütünleme";
            //}
            //else
            //{
            //    result = "Sınavı geçemediniz ve bütünleme hakkınız yok.";
            //}
            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine().ToLower();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Girdiğiniz şehir Türkiye'de bulunmaktadır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz şehir olan " +city + " Türkiye'de bulunmamaktadır.");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username= Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı sistemde kayıtlı değildir.");
            //}
            //else
            //{
            //    Console.Write("Lütfen şifrenizi giriniz: ");
            //    string password = Console.ReadLine();
            //    if (password != "1234")
            //    {
            //        Console.Write("Şifre hatalı");
            //    }
            //    else
            //    {
            //        Console.Write("Sisteme giriş yaptınız.");
            //    }
            //}

            #endregion

            #region Mod İşlemleri


            //int number;
            //number = 26;
            //int sonuc = number % 5;
            //Console.WriteLine("Sonuç: " + sonuc);

            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının, 2.sayıya bölümünden kalan: "+ result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tektir.");
            //}
            #endregion

            #region Char Değişkenleriyle Karar Yapıları
            //  char teamcharacter;
            //  Console.Write("Lütfen takımınızın baş harfini giriniz: ");
            //teamcharacter = char.Parse(Console.ReadLine().ToUpper());
            //  if(teamcharacter == 'F')
            //  {
            //      Console.WriteLine("Takımınız Fenerbahçe");
            //  }
            //  if (teamcharacter == 'B')
            //  {
            //      Console.WriteLine("Takımınız Beşiktaş");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Girmiş olduğunuz takımın baş harfi sistemde kayıtlı değildir.");
            //  }
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Lütfen detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if(menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2- Patates Kızartması");
            //    Console.WriteLine("3- Fasulyeli Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //}
            //if(menuItem =="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorba ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("---------- Çorba ----------");
            //}
            //if(menuItem =="3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margherita");
            //    Console.WriteLine("2-Marinara ");
            //    Console.WriteLine("3-Capricciosa ");
            //    Console.WriteLine("4-Diavola ");
            //    Console.WriteLine("5-Pepperoni ");
            //    Console.WriteLine("---------- Pizzalar ----------");
            //}
            //if(menuItem =="4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Çay");
            //    Console.WriteLine("2-Matcha Latte ");
            //    Console.WriteLine("3-Su ");
            //    Console.WriteLine("4-Ayran  ");
            //    Console.WriteLine("5-Cola Zero ");
            //    Console.WriteLine("---------- İçecekler ----------");
            //}
            //if(menuItem =="5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Cheesecake ");
            //    Console.WriteLine("3-Magnolya ");
            //    Console.WriteLine("4-Havuç Dilimi");
            //    Console.WriteLine("5-Trileçe");
            //    Console.WriteLine("---------- Tatlılar ----------");
            //}




            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen ay girişi yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());

            //Switch kullanabilmek için kullanıcıdan veri girişi alacağın değişkeni switch(değişken){} yaparak case1: break;,case2: break;,case3: break; ve daha fazla case almayacaksan default: break; şeklinde kullanabilirsin. 

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Geçerli bir sayı girişi yapmadınız."); break;








            #endregion

            #region Switch Case Hesap Makinesi

            //int n1, n2;
            //double result = 0;

            //char operation;
            //Console.WriteLine("Please enter the first number: ");
            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number: ");
            //n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please indicate the mathematical operation");
            //operation = Char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        result = n1 + n2; break;

            //    case '-':
            //        result = n1 - n2; break;
                
            //    case '*':
            //        result = n1 * n2; break;

            //    case '/':
            //        result = n1 / n2; break;

            //    default: Console.WriteLine("You  entered an invalid operation"); break;


            //}
            //Console.WriteLine("The result is: " + result);



            #endregion


        }
    }
}
