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

            Console.WriteLine($"The average grade of {book.Name} is {stats.Average:N1}");
            Console.WriteLine($"The highest grade of {book.Name} is {stats.High:N1}");
            Console.WriteLine($"The lowest grade of {book.Name} is {stats.Low:N1}");                      
            Console.WriteLine($"The letter Grade is {stats.Letter}");
        }
    }
}
