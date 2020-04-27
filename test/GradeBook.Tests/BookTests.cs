using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {  
           //arrange
           var book = new Book("");
           book.AddGrade(55.6);
           book.AddGrade(47.8);
           book.AddGrade(38.3);

           //act
           var result = book.GetStatistics();
           //assert
           Assert.Equal(47.2, result.Average, 1);
           Assert.Equal(55.6, result.High, 1);
           Assert.Equal(38.3, result.Low, 1);
        }
    }
}
