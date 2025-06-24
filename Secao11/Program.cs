namespace Secao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Programa para rodar:");
                Console.WriteLine("1 - Class 130 Program");
                Console.WriteLine("2 - Class 131 Program");
                Console.WriteLine("3 - Class 132 Program");
                Console.WriteLine("4 - Class 133 Program");
                Console.WriteLine("5 - Class 134 Program");
                Console.WriteLine("0 - Exit");
                Console.Write("Número do Programa: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Class130.Program.Run();
                        break;
                    case "2":
                        Class131.Program.Run();
                        break;
                    case "3":
                        Class132.Program.Run();
                        break;
                    case "4":
                        Class133.Program.Run();
                        break;
                    case "5":
                        Class134.Program.Run();
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



