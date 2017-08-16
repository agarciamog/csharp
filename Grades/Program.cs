using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = new ThrowAwayGradeBook();
            //GetBookName(book);
            AddGrades(book);
            WriteGradesToFile(book);
            ShowGrades(book);
        }

        private static void ShowGrades(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        private static void WriteGradesToFile(IGradeTracker book)
        {
            StreamWriter outputFile = File.CreateText("grades.txt");
            try
            {

                book.WriteGrades(outputFile);
            }
            finally
            {

                outputFile.Close();
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(85);
            book.AddGrade(76.4f);
            book.AddGrade(59);
        }

        private static void GetBookName(GradeTracker book)
        {
            // += allows for multiple methods to be added to event/delegate book.NameChanged.
            book.NameChanged += new NameChangedDelegate(OnNameChanged); // comment out to fire NullReferenceException

            //book.Name = "Alberto's Grade Book";
            //book.Name = null; // Uncomment to throw ArguementException in GradeBook Name property

            try // Exception Handling
            {
                Console.WriteLine("Enter a grade book name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
