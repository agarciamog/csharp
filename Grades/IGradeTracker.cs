using System.IO;

namespace Grades
{
    public interface IGradeTracker
    {
        string Name { get; set; }
        void WriteGrades(TextWriter destination);
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
    }
}