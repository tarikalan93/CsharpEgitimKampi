using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri

            //string[] colors = new string[4];

            //colors[0] = "Sarı";
            //colors[1] = "Yeşil";
            //colors[2] = "Mavi";
            //colors[3] = "Kırmızı";

            //Console.WriteLine (colors[0]);
            //Console.WriteLine (colors[1]);
            //Console.WriteLine(colors[2]);
            //Console.WriteLine(colors[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 24;
            //numbers[1] = 32;
            //numbers[2] = 84;
            //numbers[3] = 786;
            //numbers[4] = 962;

            //string[] students = { "Engin", "Derin", "Salih" };
            //Console.WriteLine(students[0]);

            #endregion

            #region dizideki tüm elemanları yazdırma

            //string[] colors = { "Mavi", "Siyah", "Beyaz", "Kırmızı", "Yeşil" };

            //for (int i =0; i<colors.LongLength; i++)

            //{
            //    Console.WriteLine(colors[i]);

            // }

            //int[] numbers = { 4, 85, 56, 89, 774, 5556, 888, 45, 89, 66333 };

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    if (numbers[i] % 4 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }

            //}

            //char[] symbols = { 'a', 'b', 'c', '*' };

            //for (int i = 0; i < symbols.Length; i++)

            //{

            //    Console.WriteLine(symbols[i]);
            //}

            //int[] MyArray = { 789, 56, 69, 855, 987, 2, 56, 5, 26, 889 };

            //int maxNumber = MyArray[0];

            //for (int i = 0; i < MyArray.Length; i++)

            //{
            //    if (MyArray[i] > maxNumber)
            //    {
            //        maxNumber = MyArray[i];
            //    }

            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Ahmet", "Veli", "Orhan" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 5, 8, 9, 6, 444, 888, 555, 999, 888 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] cities = { "Ankara", "Adana", "Adıyaman", "Zonguldak", "Ordu" };
            //Array.Sort(cities);
            //for (int i=0; i<cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}

            #endregion

            #region dizi metotları

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse" };

            //int index = Array.IndexOf(persons, "Buse");

            //Console.WriteLine(index);

            //int[] numbers = { 45, 89, 655, 89, 63, 88, 52 };

            //Console.WriteLine("Dizini en büyük elemanı" + numbers.Max());

            #endregion

            #region kullancıdan değer alma

            //int deger = 0;

            //Console.WriteLine("Lütfen değer giriniz...");

            //deger = int.Parse(Console.ReadLine());

            //string[] cities = new string[deger];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}

            //Console.WriteLine("girdiğiniz şehirler: ");

            //for (int i = 0; i < cities.Length; i++)

            //{

            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 15, 125, 53, 466, 58, 688, 71, 83, 956, 80 };

            //Console.WriteLine("Çift sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("tek sayılar");

            //for (int i = 0; i < numbers.Length; i++)

            //{

            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


                #endregion

            }
        }
    }
