using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace csharpsyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new book("Mert's Book");
            book1.AddGrade(100.0);
            book1.AddGrade(97.1);
            book1.ShowStatics();
        }
    }
}