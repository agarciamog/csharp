﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            // += allows for multiple methods to be added to event/delegate book.NameChanged.
            book.NameChanged += new NameChangedDelegate(OnNameChanged);

            //book.Name = "Alberto's Grade Book";
            //book.Name = null; // Uncomment to throw ArguementException in GradeBook Name property

            try // Exception Handling
            {
                Console.WriteLine("Enter a grade book name: ");
                book.Name = Console.ReadLine();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            book.AddGrade(85);
            book.AddGrade(76.4f);
            book.AddGrade(59);
            book.WriteGrades(Console.Out);
            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"The book has changed from {args.ExistingName} to {args.NewName}");
        }
    }
}
