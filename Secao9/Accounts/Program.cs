using Secao9.Accounts.Entities;

namespace Secao9.Accounts
{
    class Program
    {
        public static void Run()
        {
            Account account = new Account(1001, "Vader", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Anakin", 0.0, 500.0);

            // UPCASTING (subclasse -> superclasse)
            Account account2 = businessAccount;
            Account account3 = new BusinessAccount(1003, "Obi-wan", 0.0, 200.0);
            Account account4 = new SavingsAccount(1004, "Palpatine", 0.0, 0.01);

            // DOWNCASTING. (superclasse -> subclasse)
            //BusinessAccount account5 = account3; -> Não funciona porque pro compilador o que vale é o tipo da variável que, nesse caso, é Account.
            BusinessAccount account5 = (BusinessAccount)account3;
            BusinessAccount account5v2 = account3 as BusinessAccount; // -> Outra forma de fazer o casting.

            // BusinessAccount businessAccount6 = (BusinessAccount)account4; -> Embora o compilador não tenha acusado, vai dar erro em tempo de execução, porque o account4 foi instanciado como um SavingsAccount.

            // Obs: é uma operação insegura, só usar quando for necessário e testar se não dá um erro em tempo de execução
            if (account4 is BusinessAccount)
            {
                BusinessAccount account6 = (BusinessAccount)account4;
                account6.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (account4 is SavingsAccount) { 
                SavingsAccount account6 = (SavingsAccount)account4;
                account6.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Account testWithdraw1 = new Account(1001, "Alex", 500.0);
            Account testWithdraw2 = new SavingsAccount(1001, "Diana", 500.0, 0.01);

            testWithdraw1.Withdraw(10.0);
            testWithdraw2.Withdraw(10.0);

            Console.WriteLine(testWithdraw1.Balance);
            Console.WriteLine(testWithdraw2.Balance);

        }
    }
}
