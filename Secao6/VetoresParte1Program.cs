using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6
{
    internal class VetoresParte1Program
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n]; // Cria o vetor de doubles com tamanho N.

            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vetor[i];
            }

            double average = sum / n;

            Console.WriteLine("AVERAGE HEIGHT: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
