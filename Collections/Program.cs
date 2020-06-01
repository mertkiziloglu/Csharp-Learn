using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           //dizi tanımlama
           string[] Weekdays =
           {
               "Monday",
               "thuesday",
               "wednsday",
               "thursday", 
               "friday",
               "saturday",
               "sunday"
           };
          
           //  1-döngü elemanlarını ise foreach dngüsü ile döndüdürüz
           foreach (var days in Weekdays)
           {
               Console.WriteLine(days);
           }

           Console.WriteLine("whose chose day ? example (1=monday)");
           int iday = Int32.Parse(Console.ReadLine());
           
           /* 2- [iday] dizi olduğundan dizi indexi 0 ile başlar  (zero index) yani en son 6. indexde 7. elemanı gösterir
              3- [iday-1] dizi dediğimizde ise dizinin bütün elemanlarını tam sırasında  gösterir
              4- diyelim ki wednedayi yanlış yazdık o zamaan diziye sonradan o dizindeki elemanın doğrusunu yazarız  */

           Weekdays[2] = "wednesday";  //dizinin 2. indexi şu an wednesday oldu 
           
           if (iday >= 0 && iday <= 7)   
           {
              string chosenday = Weekdays[iday-1];
              Console.WriteLine( $"that day is {chosenday}"); 
           }
           else
           {
               Console.WriteLine("wrong chose ( 0-1-2-3-4-5-6) try again");
           }
           
        }
    }
}