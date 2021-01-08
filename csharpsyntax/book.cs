using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpsyntax
{
    public class book
    {
        public book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStatics()
        {
            var result = 0.0;
            var grades = new List<double>() {10, 30, 61, 40, 50};
            var highgrade = double.MinValue;
            var lowgrade = double.MaxValue;

            foreach (var grade in grades)
            {
                highgrade = Math.Max(grade,highgrade);
                lowgrade = Math.Min(grade,lowgrade);
                
                result += grade;
                Console.WriteLine(result);
            }

            Console.WriteLine(highgrade + " = highgrade");
            Console.WriteLine(lowgrade + " = lowgrade");

            result /= grades.Count;
            Console.WriteLine($"This is grade avarage {result}");
        }

        private List<double> grades;
        public string name;

      
    }
}