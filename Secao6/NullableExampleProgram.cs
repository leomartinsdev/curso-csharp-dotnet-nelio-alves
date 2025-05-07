using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao6
{
    internal class NullableExampleProgram
    {
        public static void Run()
        {
            // double x = null; -> dá erro pois um struct não pode receber nulo.
            Nullable<double> x = null; // -> Aqui eu estou dizendo que a variável x pode receber nulo, pois é um tipo Nullable.

            double? y = null; // -> Aqui eu estou dizendo que a variável y pode receber nulo, pois é um tipo Nullable (maneira mais concisa).
            double? k = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(k.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(k.HasValue);

            // Console.WriteLine(x.Value);-> Aplicação quebra e lança uma exceção. O objeto Nullable precisa ter um valor.
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x não tem valor.");
            }
            Console.WriteLine(k.Value);

            // Operador de coalescência nula
            double a = x ?? 5.0; // Se x for nulo, a recebe 5.0
            double b = k ?? 5.0; // Se k for nulo, b recebe 5.0
        }
    }
}
