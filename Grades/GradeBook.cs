﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    public class GradeBook
    {
        protected List<float> grades; // Protected, can be used by this class, or inheriting class.
        private string _name;   // Private, can be used by this class.
        public event NameChangedDelegate NameChanged; // Public, can be used by anyone.

        public GradeBook()
        {
            _name = "None";
            grades = new List<float>();
        }

        // Property
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value;

            }
        }

        public void WriteGrades(TextWriter destination)
        {
            foreach (float grade in grades)
            {
                destination.WriteLine(grade);
            }
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public virtual GradeStatistics ComputeStatistics()
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
    }
}
