using Secao8.OrderProgram.Entities;
using Secao8.OrderProgram.Entities.Enums;

namespace Secao8.OrderProgram
{
    internal class OrderProgram
    {
        public static void Run()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // Converte um Enum para String
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Converte uma string para um Enum

            Console.WriteLine(txt);
            Console.WriteLine(os);


        }
    }
}