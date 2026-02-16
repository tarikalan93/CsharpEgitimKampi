using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach loop

            //string[] students = new string[3] { "John", "Jane", "Jack" };

            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);

            //}

            //int[] numbers = { 15, 25, 34, 42, 50, 69, 86 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)

            //    {
            //        Console.WriteLine(number);
            //    }

            //}

            //List<string> students = new List<string>() { "John", "Jane", "Jack" };

            //foreach (var names in students)
            //{
            //    Console.WriteLine(names);

            //}

            //string word = "Hello World";

            //foreach (var item in word)
            //{
            //   Console.WriteLine(item);
            //}



            #endregion 

            #region sınav sistemi 

            //Console.WriteLine("******** C# Eğitim Kampı Sınav Uygulaması ********");
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftaki öğrenci sayısını kullanıcıdan alalım
            //Console.WriteLine("----------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("----------------------------");

            //// öğrenci isimlerini ve notlarını tutmak için iki ayrı dizi tanımlayalım
            //string[] students = new string[studentCount];
            //double[] grades = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)

            //{
            //    Console.WriteLine($"{i + 1}. öğrencinin ismini giriniz");
            //    students[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    // Her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{students[i]} isinli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }

            //    grades[i] = totalExamResult / 3;
            //}

            //// Sınav ortalamaları

            //for (int i=0; i<studentCount; i++)
            //{
            //    Console.WriteLine($"{students[i]} adlı öğrencinin ortalaması: {grades[i]}");

            //    // Sınav ortalamasına göre öğrencinin geçip kalma durumunu belirleyelim
            //    if (grades[i] >= 50)
            //    {
            //        Console.WriteLine($"{students[i]} adlı öğrenci dersten geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{students[i]} adlı öğrenci dersten kaldı.");
            //    }
            //}


            #endregion
        }
    }
}
