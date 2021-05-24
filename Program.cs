using System;

namespace TEcnicalQuestion
{
    class Program
    {
        public static void Main()
        {
            int x = 100;
            int y = 20;
 
            x = x + y;
            y = x - y;
            x = x - y;
            
            Console.WriteLine("After swapping: x = " + x + ", y = " + y);
        }
    }
}