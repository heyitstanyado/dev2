using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracking_The_Coding_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "this string is not unique";
            string test2 = "astr"; 

            var prog = new Ch1_ArraysAndStrings();

            var result1 = prog.IsUnique(test1);
            var result2 = prog.IsUnique(test2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadKey(); 

            

        }
    }
}
