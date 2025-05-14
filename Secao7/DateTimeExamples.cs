using System;
using System.Globalization;

namespace Secao7
{
    internal class DateTimeExamples
    {
        public static void Run()
        {
            // Retorna o horário atual do sistema
            DateTime d1 = DateTime.Now;

            // Instancia um datetime nessa data
            DateTime d2 = new DateTime(2018, 11, 25);
            // ou DateTime d2 = new(2018, 11, 25);

            // Mesma coisa mas definindo as horas 20:45:03
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);

            // Com milissegundos
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

            // Retorna a data de hoje no horário da 00h
            DateTime d5 = DateTime.Today;

            // Horário de agora mas no GMT ( Greenwich )
            DateTime d6 = DateTime.UtcNow;

            // Converte uma data em string para DateTime
            DateTime d7 = DateTime.Parse("16/08/1997");
            DateTime d8 = DateTime.Parse("16/08/1997 14:45:45");
            DateTime d9 = DateTime.Parse("1997-08-16");
            DateTime d10 = DateTime.Parse("1997-08-16 13:05:58");

            // Você determina o formato da data
            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 10:52:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            // Quantidade de ticks desde o dia 01/01 00:00 da era atual
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
