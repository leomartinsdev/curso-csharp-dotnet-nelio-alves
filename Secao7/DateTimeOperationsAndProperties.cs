using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao7
{
    internal class DateTimeOperationsAndProperties
    {
        public static void Run()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            // Propriedades
            Console.WriteLine(d);
            Console.WriteLine("Date: " + d.Date);
            Console.WriteLine("Day: " + d.Day);
            Console.WriteLine("DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("DayOfYear: " + d.DayOfYear);
            Console.WriteLine("Hour: " + d.Hour);
            Console.WriteLine("Kind: " + d.Kind);
            Console.WriteLine("Millisecond: " + d.Millisecond);
            Console.WriteLine("Minute: " + d.Minute);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Second: " + d.Second);
            Console.WriteLine("Ticks: " + d.Ticks);
            Console.WriteLine("TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("Year: " + d.Year);

            // DateTime.To... tem várias opções de conversão, alguns exemplos:
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToLocalTime());

            // Máscara de formatação
            string s1 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s1);

            string s2 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s2);

            // Algumas operações
            DateTime dt1 = d.AddHours(2);
            Console.WriteLine(dt1);

            DateTime dt2 = d.AddMinutes(7);
            Console.WriteLine(dt2);

            DateTime dt3 = d.AddSeconds(8);
            Console.WriteLine(dt3);

            // Existem várias outras opções na documentação.
        }
    }
}
