using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =new int[5]{1, 3, 5, 6, 9};
             
            Stack<int>aStack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                aStack.Push(numbers[i]);
            }
            foreach (int aPop in aStack)
            {
                Console.WriteLine(aPop);
            }
            Console.ReadKey();
        }
    }
}
