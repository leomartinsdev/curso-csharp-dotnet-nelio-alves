using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao7
{
    internal class TimeSpanExamples
    {
        public static void Run()
        {
            // TimeSpan é uma duração, um intervalo entre dois instantes.
            // Internamente ele armazena uma duranção na forma de ticks (1 tick = 100 nanosegundos).

            TimeSpan t1 = new TimeSpan(0, 1, 30); // 0 hora, 1 minuto e 30 segundos.
            TimeSpan t2 = new TimeSpan(900000000); // 900 milhões de ticks (1:30 minuto)
            TimeSpan t3 = new TimeSpan(2, 11, 30);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(2.5);
            TimeSpan t8 = TimeSpan.FromMinutes(180);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1000);
            TimeSpan t11 = TimeSpan.FromTicks(900000000);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);


            // Algumas propriedades
            TimeSpan v1 = TimeSpan.MaxValue;
            TimeSpan v2 = TimeSpan.MinValue;
            TimeSpan v3 = TimeSpan.Zero;
            TimeSpan v4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(v4.Days);
            Console.WriteLine(v4.Hours);
            Console.WriteLine(v4.Minutes);
            Console.WriteLine(v4.Milliseconds);
            Console.WriteLine(v4.Seconds);
            Console.WriteLine(v4.Ticks);

            // Algumas operações
            TimeSpan o1 = new TimeSpan(1, 30, 10);
            TimeSpan o2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = o1.Add(o2);
            TimeSpan dif = o1.Subtract(o2);
            TimeSpan mult = o2.Multiply(2);
            TimeSpan div = o2.Divide(2);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
