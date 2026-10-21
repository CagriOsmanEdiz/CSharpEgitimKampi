using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //i=1 olmak üzere 20'ye eşit ve küçük olana kadar ekrana i birer birer artırarak yazdır

            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //    //i=3 olmak üzere 50'ye eşit ve küçük olana kadar ekrana i değerini üçer üçer artırarakyazdır
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adeti giriniz: ");
            //int finishvalue= int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishvalue; i++) {
            //    Console.WriteLine("YAŞASIN CUMHURİYET");

            // finishvalue değerine kullanıcıdan input ile değer atanır ve ona göre döngü oluşturulur.

            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    // == eşitse anlamına gelir, = ise atama olarak kullanılır.
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //    //totalValue+=i, totalValue değeri ile i değerini topla ve totalValue değişkenine ata demektir.

            //    Console.WriteLine(totalValue);
            //}

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            ////0-50 sayıları arasında 7 rakamına tam bölünen kaç tane sayı olduğunu gösteren kod.

            //Console.WriteLine(count);


            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2; // bacterium = bacterium*2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium);


            //}








            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    //i++; yazmamınızı sebebi şudur: Bu satırı eklemediğimiz sürece while döngüsü içindeki koşul sonsuza kadar sağlanacak ve kod sonsuza kadar ekrana 1 yazdıracaktır. 
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i; // sum = sum+i;
            //    i++;
            //    Console.WriteLine(sum);
            //}

            //Console.WriteLine("------");
            //Console .WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.WriteLine("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //sum = ones + tens + hundreds;

            //Console.WriteLine("Birler basamağı: " + ones);
            //Console.WriteLine("Yüzler Basamağı: " + hundreds);
            //Console.WriteLine("Onlar Basamağı: " + tens);

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //Console.WriteLine(sum);



            #endregion

        }
    }
}
