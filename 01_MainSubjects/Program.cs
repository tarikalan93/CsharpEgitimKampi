using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***Yemek Kategorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();

            //Console.Read();
            #endregion

            #region StringDegiskenler

            //string name;
            //name = "Tarık";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurmaname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Tarık";
            //customerSurmaname = "Alan";
            //customerPhone = "5523731673";
            //customerEmail = "deneme@gmail.com";
            //district = "Pendik";
            //city = "İstanbul";

            //Console.WriteLine("****Rezervasyon Kartı****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurmaname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);

            #endregion

            #region IntDegiskenler

            Console.WriteLine("*** Restoran fiyat listesi ***");
            Console.WriteLine();

            int hamburgerPrice = 450;
            int pizzaPrice = 50;
            int colaPrice = 85;
            int lemonadePrice = 80;
            int friesPrice = 260;
            int waterPrice = 25;

            Console.WriteLine("--- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("--- Pizaa: " + pizzaPrice + " TL");
            Console.WriteLine("--- Kola: " + colaPrice + " TL");
            Console.WriteLine("--- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("--- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("--- Su: " + waterPrice + " TL");
            Console.WriteLine();

            Console.WriteLine();

            int hambugerCount;
            int pizzaCount;
            int colaCount;
            int lemonadeCount;
            int friesCount;
            int waterCount;

            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalColaPrice;
            int totalLemonadePrice;
            int totalFriesPrice;
            int totalWaterPrice;

            hambugerCount = 3;
            colaCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hambugerCount * hamburgerPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalColaPrice = colaCount * colaPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            
            Console.WriteLine();
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Su tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kola tutarı: " + totalColaPrice + "TL");
            Console.WriteLine("Limonata tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalColaPrice + totalFriesPrice + totalLemonadePrice + totalWaterPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Tutar :" + totalPrice);
            #endregion

            Console.Read();

        }
    }
}
