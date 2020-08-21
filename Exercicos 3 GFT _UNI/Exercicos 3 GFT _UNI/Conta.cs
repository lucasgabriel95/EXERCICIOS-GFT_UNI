using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicos_3_GFT__UNI
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
    }
}
