using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao7
{
    internal class DateTimeKindProgram
    {
        public static void Run()
        {
            // DateTimeKind é um tipo enumerado especial que define três valores possíveis para a localizade da data.
            /* Boa prática é armazenar a data em formato UTC, e instanciar e mostrar em formato local */

            // Para converter um datetime para Local ou Para UTC:
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            // Não teve diferença entre as 3.

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 King: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 King: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 King: " + d3.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());
        }
    }
}
