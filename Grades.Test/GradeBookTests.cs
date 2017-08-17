using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

namespace CSharp.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);
  
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(90, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(10, stats.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(85);
            book.AddGrade(76.4f);
            book.AddGrade(59);

            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(73.46, stats.AverageGrade, 0.01);
        }
    }
}
