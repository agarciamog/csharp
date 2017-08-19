using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> books = new Stack<string>();
            books.Push("C# Cookbook");
            books.Push("Das Capital");
            books.Push("On the Road");
            books.Push("The Next 100 Years");

            String topItem = books.Pop();
            Console.WriteLine("Removed {0}", topItem);

            Console.WriteLine("===Available Books===");
            foreach (String book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
