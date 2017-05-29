using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(0.1 + 0.2 == 0.3);    // round-off error
            Console.WriteLine(0.25 + 0.25 == 0.5);
            Console.WriteLine(1.2 + 1.3 == 2.5);
            Console.WriteLine(0.1f + 0.2f == 0.3f); // ok
        }
    }
}
