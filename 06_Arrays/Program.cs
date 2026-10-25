using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //2,4,6,8,10... bir sayı dizisidir
            // Sarı,mavi,kırmızı,beyaz bir renk dizisidir
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Mavi";
            //colors[1] = "Sarı";
            //colors[2] = "Kırmızı";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Skopje";
            //cities[2] = "Rome";
            //cities[3] = "Berlin";
            //cities[4] = "New York";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 12;
            //numbers[2] = 42;
            //numbers[3] = 8;
            //numbers[4] = 523;
            //numbers[5] = 51;
            //numbers[9] = 5;
            //// bir indexe değer ataması yapmazsan default değeri 0'dır.
            //Console.WriteLine(numbers[2]);

            //string[] cities = { "Prague", "Rome", "Athens", "Ankara", "Washington D.C" };
            //Console.WriteLine(cities[1]);

            #endregion

            #region  Dizideki Tüm Elemanları Listele

            //string[] colors = { "Sarı", "Kırmızı", "Yeşil", "Pembiş", "Beyaz", "Siyah", "Lacivert" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 123, 6442, 5678, 112, 24, 567, 12 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //    // numbers dizinini i. değeri 3 sayısına tam bölünürse o sayıyı ekrana yazdır ve bir alt satıra geç
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'ş', 'i'};

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 22, 55, 66, 77 };
            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   if(numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "Ali", "Cem", "Mehmet", "Çağrı", "Beyhan" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 121, 24, 23, 34, 51, 62};
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 121, 24, 23, 34, 51, 62};
            //Array.Sort(numbers); // Diziyi küçükten büyüğe sıralar.
            //Array.Reverse(numbers);// Diziyi en sondan en başa olarak yeniden sıralar
            //// Bu 2 komut birlikte kullanılırsa dizi en büyükten en küçüğe olmak üzere sıralanır.
            //for(int i = 0; i < numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Ahmet", "Beyhan" };
            //// Bu benim hoca söylemeden kendimin düşünüp yaptığı şey
            //for (int i = 0; i < customers.Length; i++)
            //{
            //    if (customers[i] == "Beyhan")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Ahmet", "Beyhan" };
            //int index = Array.IndexOf(customers, "Beyhan");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 24, 123,44,156,774,22 };
            //Console.WriteLine("Dizinin en büyük elemanı: "+ numbers.Max()+ " Dizinin en küçük elemanı: "+ numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}   
            //Console.WriteLine(sum);

            //int[] numbers= {1,2,3,4,5,6,7,8,9,10};

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("-----------------------------");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine($"{numbers[i]} sayısı çifttir");
            //    }
              
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("-----------------------------");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine($"{numbers[i]} sayısı tektir");
            //    }
            //}


            #endregion
        }

    }
}
