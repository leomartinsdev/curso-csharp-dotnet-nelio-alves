using System.Globalization;

namespace Secao4
{
    internal class ProgramCircunferenciaStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double circ = CalculadoraStatic.CalcularCircunferencia(raio);
            double volume = CalculadoraStatic.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + CalculadoraStatic.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
