using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;

namespace csharpsyntax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           var book=getbook("book1");
         
           var book2=getbook("book2");
           Assert.Equal("book1",book.name);
           Assert.Equal("book2",book2.name);
        }    
        
                
        book getbook(string name)
        {
            return new book(name);
        }
    }
}