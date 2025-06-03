namespace Secao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha um Programa para rodar:");
                Console.WriteLine("1 - AccountsProgram");
                Console.WriteLine("2 - SolvedExercise1");
                Console.WriteLine("3 - Exercise1");
                Console.WriteLine("0 - Exit");
                Console.Write("Número do Programa: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Accounts.Program.Run();
                        break;
                    case "2":
                        SolvedExercise1.Program.Run();
                        break;
                    case "3":
                        Exercise1.Program.Run();
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


