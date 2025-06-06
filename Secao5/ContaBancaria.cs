﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao5
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        private int TaxaSaque = 5;

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        { 
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + TaxaSaque;
        }

        public override string ToString()
        {
            return "Conta"
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2");
        }

    }
}
