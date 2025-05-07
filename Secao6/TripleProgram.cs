using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao6
{
    internal class TripleProgram
    {
        public static void Run()
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
