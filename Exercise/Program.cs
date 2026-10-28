using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir şeyi 3'ten fazla kez tekrar ediyorsan, orada mutlaka bir döngü (for/foreach) kullanılmalıdır.
            // İlerleyen yerlerde işime yarayacak not:
            //cities.ForEach(x => Console.WriteLine(x)); => Listeden gelen her elemanı x adıyla tut $\rightarrow$ x değişkenini alıp Console.WriteLine komutuna parametre olarak ver ve çalıştır."

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

            #region 06_Arrays_Practice

            #region 1. Soru: Rastgele Sayı Dizisinde Çift/Tek ve Max/Min Analizi

            //int[] numbers = { 1, 23, 55, 36, 83, 14, 74, 77, 22, 73 };

            //// Diziyi küçükten büyüğe sıralar
            //Array.Sort(numbers);

            //Console.WriteLine("Dizideki en büyük sayı: " + numbers.Max());
            //Console.WriteLine("Dizideki en küçük sayı: " + numbers.Min());

            //int ciftToplam = 0;
            //int tekToplam = 0;
            //int tekAdet = 0; // Ortalamayı hesaplayabilmek için tek sayı adedini tutuyoruz

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        ciftToplam += numbers[i];
            //    }
            //    else // % 2 == 0 değilse kesinlikle tektir
            //    {
            //        tekToplam += numbers[i];
            //        tekAdet++; // Her tek sayı bulduğumuzda adedi 1 artırıyoruz
            //    }
            //}

            //// Ortalamayı küsüratlı (ondalıklı) alabilmek için (double) dönüşümü yapıyoruz
            //double tekOrtalama = (double)tekToplam / tekAdet;

            //Console.WriteLine("Dizideki çift sayıların toplamı: " + ciftToplam);
            //Console.WriteLine("Dizideki tek sayıların ortalaması: " + tekOrtalama);




            #endregion

            #region 2. Soru: Öğrenci Not Otomasyonu (Kullanıcıdan Değer Alma & Arama)

            //string[] student = new string[5];
            //int[] grades = new int[5];

            //for (int i = 0; i < student.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. öğrencinin adını ve soyadını giriniz: ");
            //    student[i] = Console.ReadLine();

            //    Console.Write($"Lütfen {student[i]} isimli öğrencinin notunu giriniz: ");
            //    grades[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine("-----------------------");
            //}
            //string st;
            //Console.Write("Lütfen velisi olduğunuz öğrencinin adını ve soyadını giriniz: ");
            //st = Console.ReadLine();

            //int index = Array.IndexOf(student, st);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Velisi olduğunuz {st} isimli öğrencinin notu: {grades[index]}");
            //}
            //else
            //{
            //    Console.WriteLine("Sistemde bu isimde bir öğrenci bulunamadı.");
            //}








            #endregion

            #region 3. Soru: Sayıların Basamak Toplamı ve Filtreleme

            //int[] numbers = { 123, 45, 678, 12, 990, 341, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {

            //        Console.WriteLine(numbers[i]);
            //        Console.WriteLine("------------------------------");
            //        sum += numbers[i];
            //    }

            //}

            //Console.WriteLine("3'e bölünen sayıların toplamı: " + sum);

            #endregion

            #region 4. Soru: Şehir Arama ve Sıralama Senaryosu

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine("Lütfen Şehir Adı Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();

            //Array.Sort(cities);
            //Array.Reverse(cities);

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //Console.WriteLine($"{cities.Length} tane şehir eklendi");
            #endregion

            #region 5. Soru: Mağaza Fiyat Analizi ve Filtreleme (Kapsamlı Soru)

            //int[] prices={ 450, 1200, 80, 2300, 1500, 600, 3100, 950 };
            //int count = 0;

            //Console.WriteLine($"Listedeki en pahalı ürün ile en ucuz ürün arasındaki fark: {prices.Max() - prices.Min()}");

            //for (int i = 0; i < prices.Length; i++) 
            //{

            //    if (prices[i] >= 1000)
            //    {
            //        count++;
            //        prices[i]=(prices[i]*110)/100;
            //    }


            //}

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine($"1000 TL ve üzeri ürün sayısı: {count}");

            #endregion

            #region 6. Soru: Rastgele Sayı Tahmin Oyunu (Mantığı Kavrama)
            //int guessedNumber = 0;

            //while (guessedNumber != 29)
            //{
            //    Console.Write("Bir sayı tahmininde bulununuz: ");
            //    guessedNumber=int.Parse(Console.ReadLine());
            //    if (guessedNumber < 29)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Daha büyük bir sayı giriniz.");
            //    }

            //    else if (guessedNumber > 29)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tebrikler! Doğru sayıyı tahmin ettiniz");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region 7. Soru: Kasada Bakiye Harcama ve Çıkış

            //int bakiye = 1000;
            //int harcananTutar ;
            //while (true)
            //{
            //    Console.WriteLine("Harcamak istediğiniz tutarı giriniz (Çıkış için 0):");
            //    harcananTutar = int.Parse(Console.ReadLine());

            //    if (harcananTutar >=     bakiye)
            //    {
            //        Console.WriteLine("Yetersiz Bakiye");
            //    }
            //    else if (harcananTutar < bakiye||harcananTutar!=0)
            //    {
            //        bakiye= bakiye-harcananTutar;
            //    }
            //    else if (harcananTutar == 0 || bakiye == 0) {
            //        break;
            //    }
            //}

            //int bakiye = 1000;
            //int harcananTutar;

            //while (true)
            //{
            //    Console.WriteLine($"Mevcut Bakiyeniz: {bakiye} TL");
            //    Console.Write("Harcamak istediğiniz tutarı giriniz (Çıkış için 0): ");
            //    harcananTutar = int.Parse(Console.ReadLine());

            //    // 1. Çıkış kontrolü (0 girildi mi?)
            //    if (harcananTutar == 0)
            //    {
            //        Console.WriteLine("Çıkış yapıldı.");
            //        break;
            //    }

            //    // 2. Yetersiz bakiye kontrolü
            //    if (harcananTutar > bakiye)
            //    {
            //        Console.WriteLine("Yetersiz Bakiye!");
            //        Console.WriteLine("-----------------------------");
            //    }
            //    // 3. Başarılı harcama (Harcanan tutar bakiyeden küçük veya eşitse)
            //    else
            //    {
            //        bakiye -= harcananTutar; // bakiye = bakiye - harcananTutar ile aynıdır
            //        Console.WriteLine($"Harcama başarılı. Kalan Bakiye: {bakiye} TL");
            //        Console.WriteLine("-----------------------------");

            //        // Bakiye tamamen bitti mi kontrolü
            //        if (bakiye == 0)
            //        {
            //            Console.WriteLine("Bakiyeniz tükenmiştir. Çıkış yapılıyor.");
            //            break;
            //        }
            //    }
            //}












            #endregion

            #region 8. Soru: Sayının Basamaklarını Toplama

            //Console.Write("Sayı girişi yapınız:");
            //int number = int.Parse(Console.ReadLine());
            //int tempNumber = number;
            //int sum = 0;

            //while (tempNumber > 0)
            //{
            //    int lastDigit = tempNumber % 10;
            //    sum+= lastDigit;
            //    tempNumber=tempNumber/10;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"{number} sayısının basamakları toplamı {sum}'dır");
            #endregion

            #endregion

            #region 07_Foreach_Loops_Exercise

            #region Kasiyer & Stok Takip Otomasyonu

            //double toplamFiyat = 0;


            //Console.WriteLine("***** Ediz Market'e Hoşgeldiniz. *****");
            //Console.WriteLine("------------------------------");

            //Console.Write("Bugün kaç farklı ürün satıldı? ");
            //int soldItem = int.Parse(Console.ReadLine());
            //Console.WriteLine();



            //string[] productNames = new string[soldItem];
            //int[] productUnit = new int[soldItem];
            //double[] pricePerUnit = new double[soldItem];
            //double[] totalItemPrice = new double[soldItem];

            //for (int i = 0; i < soldItem; i++)
            //{
            //    Console.Write($"Satılan {i + 1}. ürünün adını yazınız: ");
            //    productNames[i] = (Console.ReadLine().ToUpper());

            //    Console.WriteLine();

            //    Console.Write($"{i + 1}. üründen kaç tane satıldığını yazınız: ");
            //    productUnit[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine();

            //    Console.Write($"{i + 1}. ürünün birim fiyatı nedir? ");
            //    pricePerUnit[i] = double.Parse(Console.ReadLine());

            //    Console.WriteLine();

            //    totalItemPrice[i] = pricePerUnit[i] * productUnit[i];

            //}

            //Console.WriteLine("\n===== SATIŞ ÖZETİ VE RAPOR =====");


            //for (int j = 0; j < soldItem; j++)
            //{
            //    Console.WriteLine($"Ürün Adı: {productNames[j]} - Adet: {productUnit[j]}| Toplam Tutar: {totalItemPrice[j]}");
            //    Console.WriteLine();
            //    toplamFiyat += totalItemPrice[j];



            //}

            //if (toplamFiyat > 1000)
            //{

            //    toplamFiyat = (toplamFiyat * 110) / 100;
            //    Console.WriteLine("Tebrikler, 1000 TL üzeri alışverişe %10 indirim kazandınız!");
            //    Console.WriteLine(toplamFiyat);
            //}
            //else
            //{
            //    Console.WriteLine("İndirim uygulanmadı.");
            //    Console.WriteLine($"Ödenecek Toplam Tutar: {toplamFiyat} TL");
            //}

            #endregion

            #region Scenario: "E-Ticaret Sepet ve Stok Yönetimi"

            double[] productPrices = { 150.0, 450.5, 800.0, 1200.0, 90.0, 350.0 };
            double aboveThree = 0;


            foreach (double prices in productPrices)
            {
                if (prices >= 300)
                {
                    aboveThree += prices;
                }
            }
            Console.WriteLine($"300 TL Üzeri Toplam: {aboveThree}");



            List<double> discountedProducts = new List<double>();
            foreach (var disc in productPrices)
            {
                if (disc > 500)
                {

                    discountedProducts.Add(disc * 0.80);
                }
            }
            Console.WriteLine(SepetRaporuYazdir(discountedProducts));

            string SepetRaporuYazdir(List<double> fiyatListesi)
            {
                string rapor = "İndirimli Fiyatlar: ";

                foreach (double fiyat in fiyatListesi)
                {
                    rapor += $"{fiyat} TL | ";
                }

                return rapor;


                #endregion



                #endregion

                #region 08_Methods_Exercise

                #region Soru 1 (void - Parametreli Metot)

                //void HesapFisi(string urunAdı,int adet,double birimFiyat)
                //{
                //    Console.WriteLine($"{urunAdı}- Adet: {adet} | Toplam Tutar: {adet*birimFiyat} TL");

                //}
                //HesapFisi("Etek",8, 2);

                #endregion

                #region Soru 2 (Geriye double Döndüren Metot)

                //double OrtalamaHesapla(double vize, double final)
                //{
                //    double result = (vize * 0.40) + (final * 0.60);
                //    return result;

                //}
                //Console.WriteLine(OrtalamaHesapla(40,79));

                #endregion

                #region Soru 3 (Geriye string Döndüren Koşullu Metot)

                //string EhliyetDurumu(string isim,int yas)
                //{
                //    if (yas >= 18)
                //    {
                //        return isim + " ehliyet alabilir";

                //    }
                //    else
                //    {

                //        return $"{isim}  ehliyet alamaz, {18-yas} yıl daha beklemesi gerekiyor.";
                //    }
                //}
                //Console.WriteLine(EhliyetDurumu("Çağrı Osman Ediz", 22));

                #endregion

                #region Senaryo: "Bankamatik (ATM) Para Çekme Otomasyonu"

                //string ParaCek(double bakiye,int cekilmekIstenenTutar) 
                //{
                //    if (cekilmekIstenenTutar % 10 != 0) 
                //    {
                //        return "Hata: Çekilmek istenen tutar 10 TL ve katları olmalıdır.";
                //    }
                //    if (cekilmekIstenenTutar > bakiye)
                //    {
                //        return $"Hata: Yetersiz bakiye. Mevcut bakiyeniz: {bakiye} TL.";
                //    }
                //    else
                //    {
                //        bakiye-=cekilmekIstenenTutar;
                //        int ikiYüzBanknot = cekilmekIstenenTutar / 200;
                //        cekilmekIstenenTutar -= 200*ikiYüzBanknot;
                //        int yüzBanknot = cekilmekIstenenTutar / 100;
                //        cekilmekIstenenTutar -= 100*yüzBanknot;
                //        int elliBanknot= cekilmekIstenenTutar/50;
                //        cekilmekIstenenTutar -= 50*elliBanknot;
                //        int yirmiBanknot = cekilmekIstenenTutar / 20;
                //        cekilmekIstenenTutar-= 20*yirmiBanknot;
                //        int onBanknot = cekilmekIstenenTutar / 10;
                //        cekilmekIstenenTutar -= 10*onBanknot;
                //        return $"İşlem Başarılı! {ikiYüzBanknot} adet 200 TL, {yüzBanknot} adet 100 Tl {elliBanknot} adet 50 TL, {yirmiBanknot} adet 20 Tl, {onBanknot} adet 10 TL. Kalan Bakiye: {bakiye}";
                //    }


                //}


                //Console.WriteLine(ParaCek(1500,380));



                #endregion









                #endregion




            }
    }
}
}