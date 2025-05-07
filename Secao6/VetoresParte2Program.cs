using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6
{
    internal class VetoresParte2Program
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            Product[] vetor = new Product[n]; // Cria o vetor de doubles com tamanho N.

            for (int i = 0; i < n; i++)
            {

                string productName = Console.ReadLine();
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vetor[i] = new Product { Name = productName, Price = productPrice };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vetor[i].Price;
            }

            double average = sum / n;

            Console.WriteLine("AVERAGE PRICE: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
