﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            AverageGrade = 0;
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
