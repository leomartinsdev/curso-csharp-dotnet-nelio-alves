﻿namespace Secao4
{
    internal class CalculadoraStatic
    {
        public static double Pi = 3.14;

        public static double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
