using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao4
{
    internal class Circunferencia
    {
        static double Pi = 3.14;

        static void MainOld(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            
            double circ = CalcularCircunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
