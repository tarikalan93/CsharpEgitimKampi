using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.WriteLine("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "admin123")
            //{
            //    Console.WriteLine("Hoşgeldiniz, Yönetici");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı şifre girdiniz!");
            //}

            //string capital, country;

            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{

            //    Console.WriteLine("Doğru cevap");
            //}

            //else
            //{
            //    Console.WriteLine("hatalı giriş");

            //}

            //int sayi1, sayi2, toplam;

            //Console.WriteLine("1. Sayıyı giriniz... ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı giriniz... ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Toplamı giriniz... ");
            //toplam = int.Parse(Console.ReadLine());

            //if (sayi1 + sayi2 == toplam)
            //{
            //    Console.WriteLine("Doğru cevap.");
            //}

            //else
            //{
            //    Console.WriteLine("Yanlış cevap.");

            //}

            //int exam1, exam2, exam3, avarage;
            //string result;

            //Console.WriteLine("1. Sınav notunu giriniz...");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sınav notunu giriniz...");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("3. Sınav notunu giriniz...");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav ortalaması: " + avarage);

            //if (avarage > 0 & avarage < 49)

            //{
            //    result = "Sonuç kötü";
            //}
            //else if (avarage > 49 & avarage < 75)
            //{
            //    result = "Sonuç orta";
            //}

            //else if (avarage > 75 & avarage < 85)

            //{
            //    result = "Sonuç iyi";
            //}
            //else
            //{
            //    result = "Sonuç pekiyi";
            //}

            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen kullanıcı adınızı giriniz... ");
            //string username;
            //username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Hatalı kullanıcı girdiniz...");
            //}
            //else
            //{
            //    Console.WriteLine(username + " hoşgeldiniz...");
            //}

            #endregion

            #region mod işlemleri

            //Console.WriteLine("Lütfen bir sayı giriniz...");    

            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tektir.");
            //}

            #endregion

            #region switch case

            //Console.WriteLine("Lütfen bir ay girişi yapınız...");

            //int sayi=int.Parse(Console.ReadLine());

            //switch (sayi) {
            //    case 1:
            //        Console.WriteLine("Ocak ayındasınız.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat ayındasınız.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart ayındasınız.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan ayındasınız.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs ayındasınız.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran ayındasınız.");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz ayındasınız.");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos ayındasınız.");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül ayındasınız.");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim ayındasınız.");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım ayındasınız.");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık ayındasınız.");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız.");
            //        break;
            //}
            #endregion

            #region swicth case ile hesap makinesi

            //int sayi1, sayi2, sonuc;
            //char islem;
            //Console.WriteLine("Lütfen 1. sayıyı giriniz...");
            //sayi1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. sayıyı giriniz...");
            //sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz(+,-,*,/): ");
            //islem = char.Parse(Console.ReadLine());

            //switch (islem)
            //{
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Toplama işlemi sonucu: " + sonuc);
            //        break;
            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Çıkarma işlemi sonucu: " + sonuc);
            //        break;
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Çarpma işlemi sonucu: " + sonuc);
            //        break;
            //    case '/':
            //        if (sayi2 != 0)
            //        {
            //            sonuc = sayi1 / sayi2;
            //            Console.WriteLine("Bölme işlemi sonucu: " + sonuc);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bir sayı sıfıra bölünemez!");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı işlem girdiniz!");
            //        break;
            //}

            #endregion
        }
    }

}

