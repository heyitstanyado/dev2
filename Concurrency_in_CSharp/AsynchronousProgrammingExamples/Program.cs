using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgrammingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingAsync().Wait();

            Console.WriteLine("Finsihed");
            Console.ReadKey(); 
        }

        static async Task DoSomethingAsync()
        {
            int val = 13;

            // Asynchronously wait 1 second
            await Task.Delay(TimeSpan.FromSeconds(1));

            val *= 2;

            // Asynchronously wait 1 second
            await Task.Delay(TimeSpan.FromSeconds(1));

            // System.Diagnostics.Trace.WriteLine(val);
            Console.WriteLine(val);

        }
    }
}
