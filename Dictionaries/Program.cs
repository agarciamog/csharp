using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<String, Employee>
            {
                {"AG", new Employee("Alberto Garcia", 2011) },
                {"JD", new Employee("John Doe", 2001) },
                {"BB", new Employee("Billy Bob", 2015) }
            };

            employees["JD"] = new Employee("Johnny Doe", 2001);
            employees["CC"] = new Employee("Cinthia Cervantes", 2017); // Add Employee, but if CC already exist, replace with new Employee
            employees.Add("BO", new Employee("Barack Obama", 2009)); // Add Employee
            employees.Remove("JD");

            // em is KeyValuePair<string, Employee>
            foreach (var em in employees.Keys)
            {
                Console.WriteLine(em);
            }

            Console.WriteLine("\n");
            foreach (var em in employees.Values)
            {
                Console.WriteLine(em);
            }

            Console.WriteLine("\n");
            foreach (var em in employees)
            {
                Console.WriteLine(em.Key + ",       " + em.Value);
            }

            Employee myEmp;
            bool found = employees.TryGetValue("MM", out myEmp);
            if(found)
                Console.WriteLine("\n\n Employee with Key: " + myEmp);
            else
                Console.WriteLine("\n\n No key found for MM");
        }
    }
}
