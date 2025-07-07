using Secao13.GetHashCodeProgram.Entities;

namespace Secao13.GetHashCodeProgram
{
    internal class Program
    {
        public static void Run()
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com " };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com " };
            Client c = new Client { Name = "Heitor", Email = "maria@gmail.com " };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));

            Console.WriteLine(a.GetHashCode);
            Console.WriteLine(b.GetHashCode);
            Console.WriteLine(c.GetHashCode);
        }
    }
}
