using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Budapeşte", "Ankara", "Varşova", "New York" };
            //foreach (string city in cities) // City yerine x,y,z...  de diyebilirsiniz
            //{
            //    // "X" değişkeni cities'in içine gidip tüm değerleri teker teker üstüne alacak
            //    //For döngüsündeki gibi dizinin başlangıcı kaçar kaçar artması gerektiği gibi şeyleri yazmanıza gerek yok

            //    Console.WriteLine(city);

            //}
            //int[] numbers = { 44, 22, 11, 77, 2211, 664, 5645, 114 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 44, 22, 11, 77, 2211, 664, 5645, 114 };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 44, 22, 11, 77, 2211, 664, 5645, 114 };

            //int total = 0;

            //foreach (int number in numbers) 
            //{
            //total += number;
            //}
            //Console.WriteLine(total);

            // Liste ile dizi arasındaki temel farklar:
            // 1-) Dizinin boyutu sabittir, listeye ise sonradan ekleme ya da çıkarma yapılabilir
            // 2-) Dizi boyutu belli olduğu ve RAM'de ardışık olarak tutulduğu için okuma/yazma performansı olarak en hızlı yapıdır.Liste ise kapasitesi doldukça bellek boyutunun otomatik olarak iki katına çıkarır .

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,12,44
            //};
            //// Liste metodunu klasik Console.WriteLine() metodu ile çağıramazsın.
            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(numbers);

            //}
            // Foreach döngüsü diziler ve listelerle de çalışır çünkü bunlar koleksiyon öğeleridir.


            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine($"{c}");

            //Çünkü C# dilinde string türü, arka planda aslında bir char[] (karakter dizisi / array) olarak saklanır.

            //"Merhaba" dediğinde bellekte yan yana duran 'M', 'e', 'r', 'h', 'a', 'b', 'a' karakterleri oluşur.


            //}








            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma.
            Console.WriteLine("-------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var?: ");

            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler.
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:  ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }


            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");


                //Öğrencilerin ortalaması ve geçip kalma durumu
                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-------------------------------");
            }





            #endregion





        }
    }
}
