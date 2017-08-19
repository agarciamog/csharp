using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> tasks = new Queue<string>();
            tasks.Enqueue("Do bed");
            tasks.Enqueue("Have breakfast");
            tasks.Enqueue("Clean kitchen");
            tasks.Enqueue("Mow lawn");
            tasks.Enqueue("Have lunch");

            Console.WriteLine("===Current task===");
            foreach (String task in tasks)
            {
                Console.WriteLine(task);
            }

            tasks.Dequeue();
            tasks.Dequeue();
            Console.WriteLine("\n\n===New List of task===");

            foreach (String task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
