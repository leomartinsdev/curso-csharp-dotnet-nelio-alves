using System.Globalization;

namespace Secao7
{
    internal class TernaryExample
    {
        // Sintaxe: ( condição ) ? valor_se_verdadeiro : valor_se_falso

        public static void Run()
        { 
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            desconto = (preco < 20.0) ? 0.1 : 0.05;

            Console.WriteLine("Desconto: " + desconto);
        }
    }
}
