using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao6
{
    internal class CalculatorProgram
    {
        public static void Run() {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
