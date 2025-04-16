using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao4
{
    internal class ProgramCircunferencia
    {
        static void MainOld(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double circ = calc.CalcularCircunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
