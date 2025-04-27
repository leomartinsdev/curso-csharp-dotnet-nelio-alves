using System.Globalization;

namespace Secao5
{
    internal class Produto
    {
        /*
        public string Nome;
        public double Preco;
        public int Quantidade;
        */

        /* Aula 55 - Setando os atributos como privados, para não serem acessados diretamente.
        Convenção de nomes: quando o atributo é private, mudamos ele para começar com underline e letra minúscula */
        private string _nome;
        /* Aula 57. Auto Properties. Aqui é permitido buscar o preço, mas não é permitido alterar o preço. */
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // Construtor Padrão
        public Produto()
        {
            Quantidade = 10;
        }

        // Construtores Sobrecarga com 3 parâmetros e 2 parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0; // Essa linha é dispensável porque padrão números começam com 0.
        }

        /* Aula 55 - Palavra this
        Poderia fazer dessa forma caso eu colocasse os argumentos também com letra maiúscula.
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

        /* Getter manual para Nome
        public string GetNome()
        {
            return _nome;
        }
        */


        /* Setter manual para Nome com validação
        public void SetNome(string nome)
        { 
            if (nome != null &&  nome.Length > 1)
            {
                _nome = nome;
            }
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
