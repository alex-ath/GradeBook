using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {  
           //arrange
           var book = new InMemoryBook("");
           book.AddGrade(55.6);
           book.AddGrade(47.8);
           book.AddGrade(38.3);

           //act
           var result = book.GetStatistics();
           //assert
           Assert.Equal(47.2, result.Average, 1);
           Assert.Equal(55.6, result.High, 1);
           Assert.Equal(38.3, result.Low, 1);
           Assert.Equal('F', result.Letter);
        }

/* Commenting this out since an excemption is now thrown for this
         [Fact]
        public void CheckGradesValidity()
        {  
           //arrange
           var book = new Book("");
           
           //act
           book.AddGrade(105);

           //assert (Instead of checking a valid/invalid entry, 
           //we ensure there was no entry for an invalid grade)
           Assert.Empty(book.Grades);
        }*/
    }
}
