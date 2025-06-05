using System.Globalization;
using Secao9.Accounts.Entities;

namespace Secao9.Accounts
{
    class Program2
    {
        public static void Run()
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Laura", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Leonardo", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Apolo", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account account in list) // Funciona porque tanto BusinessAccount quanto SavingsAccount herdam de Account.
            {
                sum += account.Balance;
            }

            Console.WriteLine($"Total balance: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account account in list)
            {
                account.Withdraw(10);
            }

            foreach (Account account in list)
            {
                Console.WriteLine($"Saldo atualizado de cada conta: {account.Balance}");
            }
        }
    }
}
