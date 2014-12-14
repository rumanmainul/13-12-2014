using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("22", "Namee");
            aHashtable.Add("21", "asdas");
            string courseName = (string) aHashtable["21"];
            Console.WriteLine(courseName);
            Console.ReadKey();
        }
    }
}
