using System;
using System.Globalization;

namespace Secao4
{
    internal class ProgramProduto
    {
        static void MainOld(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);

            Console.WriteLine("Dados atualizadados: " + p);
        }
    }
}
