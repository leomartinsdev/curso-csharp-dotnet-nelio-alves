using Secao9.Class_108.Entities;

namespace Secao9.Class_108
{
    internal class Program
    {
        public void Run()
        {
            BusinessAccount businessAccount = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(businessAccount.Balance);
        }
    }
}
