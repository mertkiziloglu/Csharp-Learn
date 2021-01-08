using System;
using System.Collections.Generic;

namespace Notortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades=new List<double>(){10,12,13,14,15,16};

            var avarage = 0.0;
            var result = 0.0;
            grades.Add(90);

            foreach (var grade in grades)
            {
                result += grade;
            }

            avarage = result / grades.Count;
            //N3 c# floating point number yani kayan sayılar
            //kısacası :N3 koyarsak virgülden sonra 3 basamak yazdırır
            
            Console.WriteLine($"Class Avarage = {avarage:N3} ");
        }
    }
}