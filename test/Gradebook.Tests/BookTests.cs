using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] //Attribute
        public void Test1()
        {
            //arrange 
            var book = new Book("Sarah's Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.ComputeStats();
            //assert
            Assert.Equal(85.6,result.average,1);
        }
    }
}
