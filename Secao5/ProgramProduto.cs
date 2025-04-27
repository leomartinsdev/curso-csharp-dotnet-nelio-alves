using System;
using System.Globalization;

namespace Secao5
{
    internal class ProgramProduto
    {
        public static void Run()
        {
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); // -> Usa o construtor com 3 parâmetros

            Produto p2 = new Produto(nome, preco); // -> Usa o construtor com 2 parâmetros

            /* Eu poderia iniciar a variável já com valores, usando a seguinte sintaxe:
            Produto p3 = new Produto {
                Nome = "Computador",
                Preco = 2100.00,
                Quantidade = 10
            }
            */

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

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine(p.GetNome());
            p.SetNome("Computador Gamer");
        }
    }
}
