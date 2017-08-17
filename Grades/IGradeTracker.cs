using System.Collections;
using System.IO;

namespace CSharp
{
    public interface IGradeTracker : IEnumerable
    {
        string Name { get; set; }
        void WriteGrades(TextWriter destination);
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
    }
}