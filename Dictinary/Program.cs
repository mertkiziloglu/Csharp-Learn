using System;
using System.Collections.Generic;

namespace Dictinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //dosyanın nereye kaydedilceğini seçiyor

            string filePath = @"C:\Users\90537\Desktop\extra ders pdf\Pop by Largest Final.csv";
            
            CsvReader reader = new CsvReader(filePath);
            
            Country[] countries = reader.ReadFirstNCountries(10);
            
            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            } 
        }
    }
}