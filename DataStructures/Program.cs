using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("LBJ");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            LinkedListNode<String> nixon = presidents.Find("Richard Nixon");
            presidents.AddAfter(nixon, "Gerald Ford");

            presidents.RemoveFirst();
            presidents.AddFirst("John F. Kennedy");

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }
    }
}
