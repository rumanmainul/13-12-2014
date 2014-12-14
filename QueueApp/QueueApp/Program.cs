using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> aQueue = new Queue<string>();
            aQueue.Enqueue("Jakir");
            aQueue.Enqueue("Rubel");
            aQueue.Enqueue("Asique");
            foreach (string deQueue in aQueue)
            {
                Console.WriteLine(deQueue);
            }
            Console.ReadKey();
        }
    }
}
