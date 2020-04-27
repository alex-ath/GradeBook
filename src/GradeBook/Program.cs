using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main()
        {                 
            var book = new Book("Alex's Grade Book");
            book.AddGrade(18.2);
            book.AddGrade(21.2);
            book.AddGrade(45.6);

            var stats= book.GetStatistics();  

            Console.WriteLine($"The average grade of {book.name} is {stats:N1}");
            Console.WriteLine($"The highest grade of {book.name} is {stats.High:N1}");
            Console.WriteLine($"The lowest grade of {book.name} is {stats.Low:N1}");                      
        }
    }
}
