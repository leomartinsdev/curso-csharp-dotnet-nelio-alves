namespace Secao6
{
    internal class MatrixProgram
    {
        public static void Run()
        {
            double[,] matrix = new double[2, 3]; // -> Inicializa uma matriz de 2 linhas e 3 colunas que aceita valores do tipo double.

            Console.WriteLine(matrix.Length); // -> Quantos elementos a matriz tem no total.
            Console.WriteLine(matrix.Rank); // -> Quanto é a primeira dimensão da matriz. No caso aqui, a quantidade de linhas.
            Console.WriteLine(matrix.GetLength(0)); // -> Tamanho da dimensão 0 da matriz.Aqui, o número de linhas.
            Console.WriteLine(matrix.GetLength(1)); // -> Tamanho da dimensão 1 da matriz. Aqui, o número de colunas.
        }
    }
}
