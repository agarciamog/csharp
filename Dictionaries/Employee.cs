using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Employee
    {
        public string Name { get; private set; }
        public int YearHired { get; private set; }

        public Employee(string name, int yearHired)
        {
            this.Name = name;
            this.YearHired = yearHired;
        }

        public override string ToString()
        {
            return string.Format("{0}, hired: {1}", Name, YearHired); 
        }
    }
}
