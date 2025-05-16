using System;

namespace Secao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Programa para rodar:");
                Console.WriteLine("1 - VarExample");
                Console.WriteLine("2 - TernaryExample");
                Console.WriteLine("3 - StringFunctionsProgram");
                Console.WriteLine("4 - DateTimeExamples");
                Console.WriteLine("5 - DateTimeOperationsAndProperties");
                Console.WriteLine("6 - DateTimeKindProgram");
                Console.WriteLine("7 - TimeSpanExamples");
                Console.WriteLine("8 - ISOExample");
                Console.WriteLine("0 - Exit");
                Console.Write("Número do Programa: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        VarExample.Run();
                        break;
                    case "2":
                        TernaryExample.Run();
                        break;
                    case "3":
                        StringFunctionsProgram.Run(); 
                        break;
                    case "4":
                        DateTimeExamples.Run();
                        break;
                    case "5":
                        DateTimeOperationsAndProperties.Run();
                        break;
                    case "6":
                        DateTimeKindProgram.Run();
                        break;
                    case "7":
                        TimeSpanExamples.Run();
                        break;
                    case "8":
                        ISOExample.Run();
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
