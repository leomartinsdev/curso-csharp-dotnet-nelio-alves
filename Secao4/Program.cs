using System;

namespace Secao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Programa para rodar:");
                Console.WriteLine("1 - ProgramProduto");
                Console.WriteLine("2 - ProgramTriangulo");
                Console.WriteLine("3 - Circunferencia");
                Console.WriteLine("4 - ProgramCircunferencia");
                Console.WriteLine("5 - ProgramCircunferenciaStatic");
                Console.WriteLine("0 - Sair");
                Console.Write("Número do Programa: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ProgramProduto.Run();
                        break;
                    case "2":
                        ProgramTriangulo.Run();
                        break;
                    case "3":
                        Circunferencia.Run();
                        break;
                    case "4":
                        ProgramCircunferencia.Run();
                        break;
                    case "5":
                        ProgramCircunferenciaStatic.Run();
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
