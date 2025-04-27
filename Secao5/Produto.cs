using System.Globalization;

namespace Secao5
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor Padrão
        public Produto()
        {
            Quantidade = 10;
        }

        // Construtores Sobrecarga com 3 parâmetros e 2 parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Essa linha é dispensável porque padrão números começam com 0.
        }

        /* Poderia fazer dessa forma caso eu colocasse os argumentos também com letra maiúscula.
        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = 0;
        }
        */

        /* Reaproveiando construtores:
         * Reaproveita o construtor padrão que define a quantidade = 10
            public Produto(string nome, double preco) : this()
            {
                Nome = nome;
                Preco = preco;
            }

        * Reaproveita o construtor com 2 parâmetros
            public Produto(string nome, double preco, int quantidade) : this(nome, preco)
            {
                Quantidade = quantidade;
            }
        */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
