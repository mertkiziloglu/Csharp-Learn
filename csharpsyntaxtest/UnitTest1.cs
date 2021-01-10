using System;
using System.Transactions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;

namespace csharpsyntax
{
    public class UnitTest1
    {

        //==============Değer tipi =========================//
        [Fact]
        public void ValueType()
        {
            var x = getint();
            Setint(ref x);
            Assert.Equal(x, 4);
        }

        private void Setint(ref int i)
        {
            i = 4;
        }

        private int getint()
        {
            return 3;
        }
        
        //================================================//


        //==================================================//
        [Fact]
        public void Test1()
        {
            var book3 = getbook("book3");
            Setname(book3, "New Name");
            Assert.Equal("New Name", book3.name);
        }

        private void Setname(book book3, string name)
        {
            book3.name = name;
        }

        //================================================//

        //===============================================//

        [Fact]
        public void Getbookreturnsdifferentobject()
        {
            var book1 = getbook("book1");

            var book2 = getbook("book2");
            Assert.Equal("book1", book1.name);
            Assert.Equal("book2", book2.name);
        }

        //===============================================//

        //==============================================//
        [Fact]

        // two variables can refereans same object.
        // iki değişken aynı nesneyi referans alabilir mi ?
        public void Twovarscanreferanssameobject()
        {
            var book1 = getbook("book1");

            var book2 = book1;

            /*Assert.Equal("book1",book1.name);
            Assert.Equal("book1",book2.name);*/
            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));

        }

        book getbook(string name)
        {
            return new book(name);
        }
        //==================================================//

    }
}



