using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
           Grades = new List<double>();
           Name = name;          
        }

        /* Simple Switch statement
        public void AddLetterGrade(char letter)
        {
            
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        } */
        public void AddGrade(double grade)
            {
                if (grade <= 100 && grade >= 0)
                {
                   Grades.Add(grade);
                }
                else
                {
                    System.Console.WriteLine("Invalid Value");
                }
            }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            /* Example of a foreach loop

            foreach (var grade in Grades)
            {
               result.High = Math.Max(grade, result.High);
               result.Low = Math.Min (grade, result.Low);
               result.Average += grade;
            } */

            for (var index = 0; index < Grades.Count; index += 1)
            {
               
               result.High = Math.Max(Grades[index], result.High);
               result.Low = Math.Min (Grades[index], result.Low);
               result.Average += Grades[index];
            } 
            
            /*Example of a do..while loop. I can use the 'while' statement on the top 
            instead of the "do", that way I am securing it will first check the 
            condition before running.

            var index = 0;
            do 
            {
               result.High = Math.Max(Grades[index], result.High);
               result.Low = Math.Min (Grades[index], result.Low);
               result.Average += Grades[index];
               index += 1;
            } while (index < Grades.Count); */

            result.Average /= Grades.Count;

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }
            
            return result;
        }
        public List<double> Grades;   
        public string Name;
    }
}