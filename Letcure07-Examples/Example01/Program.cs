using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            空服員 華航空姐 = new 空服員();
            華航空姐.飛行時數 = 300;

            機師 華航機師 = new 機師();
            華航機師.飛行哩程 = 12000;
        }
    }
}