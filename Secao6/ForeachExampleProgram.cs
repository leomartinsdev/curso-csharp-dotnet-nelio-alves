using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao6
{
    internal class ForeachExampleProgram
    {
        public static void Run()
        {
            // string[] vector = new string[] { "Maria", "Alex", "Bob } -> primeira opção
            string[] vector = ["Maria", "Alex", "Bob"]; // -> segunda opção

            foreach (string item in vector)
            {
                Console.WriteLine(item);
            }
        }
    }
}
