using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 02_Variables_Practice
            #region 1. Soru: Alışveriş Kasa Fişi Hesaplama (double, Console.ReadLine() & Tip Dönüşümü)
            //double bananaGram, appleGram,bananaPrice,applePrice,appletotalPrice,bananatotalPrice,totalPrice;
            //bananaPrice = 28.50;
            //applePrice = 14.75;

            //Console.WriteLine("Lütfen kaç kilo muz almak istediğiniz yazınız: ");
            //bananaGram = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen kaç kilo elma almak istediğiniz yazınız: ");
            //appleGram = double.Parse(Console.ReadLine());

            //appletotalPrice = applePrice * appleGram;
            //bananatotalPrice = bananaPrice * bananaGram;
            //totalPrice = bananatotalPrice + appletotalPrice;
            //Console.WriteLine("Toplam ödeyeceğiniz fiyat " + totalPrice + " Tl'dir");

            // Yapay zekanın yazdığı

            //double bananaPrice = 28.50;
            //double applePrice = 14.75;

            //Console.Write("Lütfen kaç kilo muz aldığınızı yazınız: ");
            //double bananaKg = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç kilo elma aldığınızı yazınız: ");
            //double appleKg = double.Parse(Console.ReadLine());

            //double appleTotalPrice = applePrice * appleKg;
            //double bananaTotalPrice = bananaPrice * bananaKg;
            //double totalPrice = bananaTotalPrice + appleTotalPrice;

            //Console.WriteLine("Toplam ödeyeceğiniz fiyat: " + totalPrice + " TL");


            #endregion

            #region 2. Soru: Öğrenci Kartı Oluşturma (string, int & Karakter Birleştirme)

            //string ad, soyad, yaş;
            //Console.Write("Lütfen adınızı giriniz: ");
            //ad = Console.ReadLine().ToUpper();

            //Console.Write("Lütfen soyadınızı giriniz: ");
            //soyad = Console.ReadLine().ToUpper();

            //Console.Write("Lütfen yaşınızı giriniz: ");
            //yaş = Console.ReadLine();

            //Console.Write("Kayıt durumu başarılı. ");

            //Console.WriteLine("***** ÖĞRENCİ KART BİLGİSİ *****");
            //Console.WriteLine("Ad Soyad: " + ad +" "+ soyad);
            //Console.WriteLine(yaş);
            //Console.WriteLine("Kayıt Durumu: Başarılı");

            // yapay zekanın yazdığı

            //Console.Write("Lütfen adınızı giriniz: ");
            //string name = Console.ReadLine().ToUpper();

            //Console.Write("Lütfen soyadınızı giriniz: ");
            //string surname = Console.ReadLine().ToUpper();

            //Console.Write("Lütfen yaşınızı giriniz: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("\n***** ÖĞRENCİ KART BİLGİSİ *****");
            //Console.WriteLine("Ad Soyad: " + name + " " + surname);
            //Console.WriteLine("Yaş: " + age);
            //Console.WriteLine("Kayıt Durumu: Başarılı");




            #endregion


            #region 3. Soru: Harf İle Not Seviyesi Kontrolü (char & if-else)
            //Console.WriteLine("Lütfen ders notunuzu giriniz: ");
            //char dersNotu = char.Parse(Console.ReadLine().ToUpper());

            //if (dersNotu == 'A')
            //{
            //    Console.WriteLine("Mükemmel Not");
            //}

            //else if (dersNotu == 'B' || dersNotu == 'C')
            //{
            //    Console.WriteLine("Geçerli Not");
            //}
            //else if (dersNotu == 'F')
            //{
            //    Console.WriteLine("Başarısız Not");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz Harf Notu");

            //}

            // Ben yazdığım kodda else ifler yerine hep if kullandığım için 'A' koşulu doğru olup 'B' C' ve 'F' geçersiz olacağı için otomatik olarak Geçersiz Harf Notu da ekrana yazdırılıyordu. Birbirleriyle bağlantılı olabilmesi için else if kullanılmalı


            #endregion



            #endregion

            #region 03_Decision_Making_Practice


            #region 1. Soru: Ehliyet ve Yaş Kontrolü (If-Else & Mantıksal Operatörler)


            //string citizen, medicalReport;
            //int citizenAge;

            //Console.WriteLine("Please enter your name:");
            //citizen = Console.ReadLine();

            //Console.WriteLine("Please enter your age:");
            //citizenAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have medical report?");
            //medicalReport = Console.ReadLine();
            //if (citizenAge == 18 & citizenAge >= 18 & medicalReport == "Yes")
            //{
            //    Console.WriteLine("You are eligible for getting a license");
            //}
            //else if (citizenAge <= 18)
            //{
            //    Console.WriteLine("You are not eligible for getting a license ");
            //}
            //if (citizenAge == 18 & citizenAge >= 18 & medicalReport == "No|no")
            //{
            //    Console.WriteLine("You must have a medical report");
            //}

            // Yapay zekanın yazdığı kod

            //Console.WriteLine("Please enter your age:");
            //int citizenAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have medical report? (yes/no)");
            //string medicalReport = Console.ReadLine().ToLower();

            //if (citizenAge < 18)
            //{
            //    Console.WriteLine("You are not eligible for getting a license.");
            //}
            //else if (medicalReport == "yes")
            //{
            //    Console.WriteLine("You are eligible for getting a license.");
            //}
            //else
            //{
            //    Console.WriteLine("You must have a medical report.");
            //}

            #endregion

            #region 2. Soru: Pozitif/Negatif ve Tek/Çift Analizi (Mod İşlemi & If-Else)

            //Console.WriteLine("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int mod;

            //if (number == 0)
            //{
            //    Console.WriteLine("Number is 0.");
            //}
            //else if (number >= 0)
            //{
            //    if (number % 2 == 0)
            //    {

            //        Console.WriteLine("Number is even and positive");
            //    }
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Number is negative");
            //}

            //if - else if - else zincirinin en önemli olayı yukarıdan aşağıya doğru sırayla çalışması ve doğru olan ilk bloğu çalıştırıp kalan tüm blokları atlamasıdır.
            // Bu yüzden 18'den büyük,küçük ve eşit olmak üzere 3 farklı if bloğunda kontrol etmiyoruz

            // Yapay zekanın yazdığı kod

            //Console.WriteLine("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number == 0)
            //{
            //    Console.WriteLine("Number is 0.");
            //}
            //else if (number > 0)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Number is positive and even.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number is positive and odd.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is negative.");
            //}


            #endregion

            #region 3. Soru: Gün İsmi ve Hafta Sonu Kontrolü (Switch-Case)

            //Console.WriteLine("Please pick a number between 1 and 7 ");
            //int number = int.Parse(Console.ReadLine());
            //switch (number)
            //{

            //    case 1: Console.WriteLine("Today is Monday"); break;
            //    case 2: Console.WriteLine("Today is Tuesday"); break;
            //    case 3: Console.WriteLine("Today is Wednesday"); break;
            //    case 4: Console.WriteLine("Today is Thursday"); break;
            //    case 5: Console.WriteLine("Today is Friday"); break;
            //    case 6: Console.WriteLine("Today is Saturday"); break;
            //    case 7: Console.WriteLine("Today is Sunday"); break;
            //    default: Console.WriteLine("You did not pick a valid number"); break;


            // Yapay zekanın yazdığı kod

            //Console.WriteLine("Please pick a number between 1 and 7: ");
            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 1: Console.WriteLine("Monday (Weekday)"); break;
            //    case 2: Console.WriteLine("Tuesday (Weekday)"); break;
            //    case 3: Console.WriteLine("Wednesday (Weekday)"); break;
            //    case 4: Console.WriteLine("Thursday (Weekday)"); break;
            //    case 5: Console.WriteLine("Friday (Weekday)"); break;
            //    case 6: Console.WriteLine("Saturday (Weekend)"); break;
            //    case 7: Console.WriteLine("Sunday (Weekend)"); break;
            //    default: Console.WriteLine("You did not pick a valid number."); break;
            //}








            #endregion

            #endregion

            #region 04_Loops_Practice

            #region 1. Soru: Belirli Aralıktaki Sayıların Toplamı (For Döngüsü & Karar Yapısı)
            //Console.Write("Lütfen bitiş sayısını giriniz: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int totalSum = 0;

            //for (int i = 1; i <= n1; i++)
            //{
            //    if (i % 3 == 0 && i % 4 == 0) // Hem 3'e hem 4'e bölünebilme
            //    {
            //        Console.WriteLine("Bölünen sayı: " + i);
            //        totalSum += i;
            //    }
            //}

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("3 ve 4'e bölünen sayıların toplamı: " + totalSum);
            #endregion





            #region 2. Soru: Kullanıcı Parola Doğrulama Simülasyonu (While Döngüsü)
            //string password = ""; // Başlangıçta boş bir değer veriyoruz

            //// Şifre "1234" olmadığı sürece döngü çalışmaya devam etsin
            //while (password != "1234")
            //{
            //    Console.Write("Lütfen şifrenizi giriniz: ");
            //    password = Console.ReadLine();

            //    if (password != "1234")
            //    {
            //        Console.WriteLine("Hatalı şifre, tekrar deneyiniz!\n");
            //    }
            //}

            //Console.WriteLine("Sisteme başarıyla giriş yapıldı.");
            #endregion

            #region 3. Soru: Sayının Basamak Sayısını ve Basamak Toplamını Bulma (While Döngüsü & Mod/Bölme)
            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int tempNumber = number; // Orijinal sayıyı kaybetmemek için yedekliyoruz
            //int sum = 0;             // Basamaklar toplamı
            //int count = 0;           // Basamak sayısı

            //while (tempNumber > 0)
            //{
            //    sum += tempNumber % 10; // Son basamağı toplama ekle
            //    tempNumber /= 10;       // Son basamağı sayıdan at
            //    count++;                // Basamak sayısını 1 artır
            //}

            //Console.WriteLine(number + " sayısı " + count + " basamaklıdır.");
            //Console.WriteLine("Basamakları toplamı: " + sum);





            #endregion
            #endregion

            #region 05_LoopsWithStar_Practice

            #region 1. Soru: Ters Sayı Piramiti

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int n = int.Parse(Console.ReadLine()); // Kullanıcıdan piramidin tavan değerini (n) alıyoruz.

            //for (int i = n; i >= 1; i--) // DIŞ DÖNGÜ: Satırları yönetir. n'den 1'e geriye sayarak hem satır numarasını hem basılacak sayıyı (5, 4, 3, 2, 1) belirler.
            //{
            //    for (int j = 1; j <= i; j++) // İÇ DÖNGÜ: Sütunları yönetir. 1'den o anki satır numarasına (i) kadar dönerek ekrana kaç adet sayı basılacağını belirler.
            //    {
            //        Console.Write(i); // O anki satır değerini (i) yan yana ekrana yazar (alt satıra geçmez).
            //    }

            //    Console.WriteLine(); // İç döngü bitince (o satırdaki tüm sayılar basılınca) bir alt satıra geçer.
            //}



            #endregion

            #region 2. Soru: Çarpım Tablosu Matrisi


            //int n = 5;

            //for (int i = 1; i <= n; i++) // DIŞ DÖNGÜ: Satırları yönetir (1. satır, 2. satır... n. satır)
            //{
            //    for (int j = 1; j <= n; j++) // İÇ DÖNGÜ: Sütunları yönetir (O satırın içindeki 1., 2... n. eleman)
            //    {
            //        Console.Write(i * j + "\t"); // Bulunduğumuz satır (i) ile sütun (j) değerini çarpıp yan yana yazar.
            //    }

            //    Console.WriteLine(); // İç döngü bitti (satırdaki 5 sayı da basıldı), bir alt satıra geç.
            //}




            #endregion

            #region 3. Soru: Sağa Dayalı Ters Dik Üçgen
            //int n = 5;

            //for (int i = 1; i <= n; i++) // DIŞ DÖNGÜ: Satırları yönetir (1'den 5'e)
            //{
            //    // 1. İÇ DÖNGÜ: Boşlukları basar (i - 1 adet)
            //    for (int j = 1; j <= i - 1; j++) // i-1 yapılmasının sebebi örneğin 1.satırda 5 yıldız basacaksak hiçbir boşluk olmaması gerekiyor.
            //    {
            //        Console.Write(" ");
            //    }

            //    // 2. İÇ DÖNGÜ: Yıldızları basar (n - i + 1 adet)
            //    for (int k = 1; k <= n - i + 1; k++) //(n - i + 1 adet) bunun sebebi ise biz 5-4-3-2-1 şeklinde yıldızların basılmasını istiyoruz. Sadece (n-i) yaparsak i=1 için 5-1=4 olur ve 4 tane yıldız basmış oluruz.
            //    {
            //        Console.Write("*");
            //    }

            //    // Satırdaki tüm karakterler basıldı, alt satıra geç
            //    Console.WriteLine();
            //}





            #endregion


            #endregion


            int n = 5;

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= n-i+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }








        }
    }
}