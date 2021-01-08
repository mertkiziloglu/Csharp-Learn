using System;
using System.Collections.Generic;

namespace PluralSight
{
    class Program
    {
        static void Main(string[] args)
        {
            var Book = new Book();
            Book.AddGrade(89.1);
            Book.grades.Add(100);


            List<double> grades = new List<double>() {10.3, 22.7, 13.0}; // list kullanımı;
            grades.Add(56.1); //listeyi dinamik bir şekilde kullanma avantajımız var 
            var result = 0.0;


            var lowgrade = double.MaxValue;
            var highgrade = double.MinValue;

            foreach (var number in grades)
            {
                /*if (number>highgrade)
                {
                    highgrade = number;
                }*/
                
                highgrade = Math.Max(number, highgrade);
                lowgrade = Math.Min(number, lowgrade);
                result += number;
            }

            result = result / grades.Count; //listenin içinde kaç elemanımızın olduğunu buluyor count 

            // sonuçtan sonra : yazmamız biçimlendirme tekniğidir örneğin :N1 virgülden sonra 1 basamak yazdır demek.
            Console.WriteLine($"the avarage is {result:N1}");
            Console.WriteLine("high grade:" + highgrade);
            Console.WriteLine("low grade:" + lowgrade);
        }
    }
}