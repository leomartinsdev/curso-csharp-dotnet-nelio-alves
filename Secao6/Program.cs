﻿using System;

namespace Secao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Programa para rodar:");
                Console.WriteLine("1 - NullableExampleProgram");
                Console.WriteLine("2 - VetoresParte1Program");
                Console.WriteLine("3 - VetoresParte2Program");
                Console.WriteLine("4 - TripleProgram");
                Console.WriteLine("5 - ForeachExampleProgram");
                Console.WriteLine("6 - ExerciseListsProgram");
                Console.WriteLine("7 - MatrixSolvedExerciseProgram");
                Console.WriteLine("0 - Exit");
                Console.Write("Número do Programa: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        NullableExampleProgram.Run();
                        break;
                    case "2":
                        VetoresParte1Program.Run();
                        break;
                    case "3":
                        VetoresParte2Program.Run();
                        break;
                    case "4":
                        TripleProgram.Run();
                        break;
                    case "5":
                        ForeachExampleProgram.Run();
                        break;
                    case "6":
                        ExerciseListsProgram.Run();
                        break;
                    case "7":
                        MatrixSolvedExerciseProgram.Run();
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
