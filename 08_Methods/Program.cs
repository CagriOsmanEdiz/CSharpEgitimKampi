using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar


            // (), bir metot olduğunu belirtir

            // İkiye ayrılırlar:

            // 1-) Geriye değer döndürmeyen metotlar
            // Customer --> Listele, ekle, sil, güncelle
            // Void --> geriye değer döndürmeyen metotlar
            // Belirli işlemleri tekrardan kurtarmak için kullanılan metotlardır.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();






            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldız");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3) 
            //{
            //int result = number1 + number2+number3;
            //Console.WriteLine(result);
            //}
            //Sum(1, 3, 6);




            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //// Bir yazdırma işlemi yapmadığım için CustomerName(); yazdığımda ekranda herhangi bir değer göremeyeceğim.
            //CustomerName();

            //string StudentCard() 
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " "+ surname;

            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor) 
            //{

            //    string cardInfo="Ülke: "+ countryName+" - Başkent: "+  capital+ " - Bayrak Rengi: "+flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //// Console.WriteLine("Ülke adını giriniz: ");
            //// x = Console.ReadLine();

            //// Console.Write("Başkenti Giriniz: ");
            //// y= Console.ReadLine();

            //// Console.Write("Bayrak Rengini Giriniz: ");
            //// z= Console.ReadLine();

            ////Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2) 
            //{
            //int result = number1+ number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {

            //        return student + "isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }

            //}

            //Console.WriteLine(ExamResult("Mehmet", 50, 60, 10));
            //Console.WriteLine(ExamResult("Ayşe", 50, 90, 50));
            #endregion
        }

    }
}
