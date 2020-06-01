﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {                 
            var book = new Book("Alex's Grade Book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
                                    
            while (true)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                
                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);            
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
                       
            var stats= book.GetStatistics();  

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The average grade of {book.Name} is {stats.Average:N1}");
            Console.WriteLine($"The highest grade of {book.Name} is {stats.High:N1}");
            Console.WriteLine($"The lowest grade of {book.Name} is {stats.Low:N1}");                      
            Console.WriteLine($"The letter Grade is {stats.Letter}");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A Grade was added!");
        }
    }
}
