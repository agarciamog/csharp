using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    public class GradeBook : GradeTracker
    {
        protected List<float> grades; // Protected, can be used by this class, or inheriting class.

        public GradeBook()
        {
            _name = "None";
            grades = new List<float>();
        }

        public override void WriteGrades(TextWriter destination)
        {
            foreach (float grade in grades)
            {
                destination.WriteLine(grade);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count();

            return stats;
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }
    }
}
