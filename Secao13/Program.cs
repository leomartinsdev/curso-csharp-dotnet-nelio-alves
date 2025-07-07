namespace Secao13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Programa para rodar:");
                Console.WriteLine("1 - Print Program");
                Console.WriteLine("2 - Calculation Program");
                Console.WriteLine("3 - GetHashCode Program");
                Console.WriteLine("3 - HashSet & SortedSet 1 Program");
                Console.WriteLine("0 - Exit");
                Console.Write("Número do Programa: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        PrintProgram.Program.Run();
                        break;
                    case "2":
                        CalculationProgram.Program.Run();
                        break;
                    case "3":
                        GetHashCodeProgram.Program.Run();
                        break;
                    case "4":
                        HashSetSortedSet1.Program.Run();
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



