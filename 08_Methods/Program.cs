using System;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

class Program
{
    //static void Main(string[] args)
    //{
    //    int sonuc = KareAl(4);
    //    Console.WriteLine(sonuc);
    //}

    //static int KareAl(int sayi)
    //{
    //    return sayi * sayi;
    //}

    //static int Topla ()

    //{
    //    return 5 + 10;

    //}

    //static void Main ()
    //{
    //    int sonuc = Topla();
    //    Console.WriteLine(sonuc);
    //}

    //static int KareAl(int sayi)

    //{
    //    return sayi * sayi;
    //}

    //static void Main()
    //{
    //    int sonuc = KareAl(5);
    //    Console.WriteLine(sonuc);
    //}

    //static decimal DesiHesapla(decimal en, decimal boy, decimal yukseklik)
    //{
    //    return (en * boy * yukseklik) / 3000;
    //}

    //static decimal KargoUcreti(decimal desi)
    //{

    //    return desi * 25;
    //}

    //static void Main()
    //{
    //    decimal desi = DesiHesapla(50, 30, 20);
    //    decimal ucret = KargoUcreti(desi);
    //    Console.WriteLine($"Desi: {desi}");
    //    Console.WriteLine($"Kargo Ücreti: {ucret}");
    //}

    //static void Main()

    //{
    //    decimal bakiye = 1000m;

    //    BakiyeGoster(bakiye);

    //    bakiye = ParaCek(bakiye, 200m);
    //    BakiyeGoster(bakiye);

    //    bakiye = ParaCek(bakiye, 2000m);
    //    BakiyeGoster(bakiye);

    //}

    //static void BakiyeGoster(decimal bakiye)
    //{
    //    Console.WriteLine($"Mevcut Bakiye: {bakiye} TL");
    //}

    //static decimal ParaCek(decimal bakiye, decimal cekilecekTutar)

    //{
    //    if (cekilecekTutar <= 0)

    //    {
    //        Console.WriteLine("Çekilecek tutar 0'dan büyük olmalı!");
    //        return bakiye;
    //    }

    //    if (cekilecekTutar > bakiye)
    //    {
    //        Console.WriteLine("Çekilecek tutar bakiyeden büyük olmamalı!");
    //        return bakiye;
    //    }

    //    decimal yeniBakiye = bakiye - cekilecekTutar;
    //    Console.WriteLine($"{cekilecekTutar} Tutarında para çekme işlemi başarılı.");
    //    return yeniBakiye;
    //}

    static void Main()
    {
        decimal bakiye = 1000m;

        while (true)
        {
            // 1) Menüyü yazdır

            Console.WriteLine("1- Bakiyeyi gör");
            Console.WriteLine("2- Para çek");
            Console.WriteLine("3- Çıkış");

            // 2) Secimi oku

            Console.WriteLine("Lütfen seçiminizi giriniz: ");
            string secim = Console.ReadLine();
            //Console.WriteLine($"Girdiğiniz seçim: {secim}");

            // 3) switch ile yönlendir

            switch (secim)
            {
                case "1":

                    Console.WriteLine($"Mevcut bakiye {bakiye} TL");
                    DevamEt();
                    break;

                case "2":

                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz...");
                    string input = Console.ReadLine();
                    decimal tutar;

                    if (decimal.TryParse(input, out tutar))
                    {
                        if (tutar <= 0)
                        {
                            Console.WriteLine("Tutar 0' dan büyük olmalı!");
                            break;
                        }

                        if (tutar > bakiye)
                        {
                            Console.WriteLine("Tutar bakiyeden büyük olamaz!");
                            break;
                        }


                        bakiye -= tutar;
                        Console.WriteLine($"{tutar} TL para çekildi. Yeni bakiye: {bakiye} TL");

                    }

                    else
                    {
                        Console.WriteLine($"Hatalı tutar girdiniz. Girilen tutar: {input}");
                    }
                    DevamEt();
                    break;

                case "3":

                    Console.WriteLine("Çıkış yapılacak");
                    return;

                default:
                    Console.WriteLine("Hatalı seçim yaptınız!");
                    DevamEt();
                    break;
            }
        }
    }

    static void DevamEt()
    {
        Console.WriteLine("Devam etmek için Enter'a basın...");
        Console.ReadLine();
        Console.Clear();

    }

}
