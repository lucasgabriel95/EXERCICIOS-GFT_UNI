using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicos_3_GFT__UNI
{
    class ContaCorrente : Conta
    {
        private double Rendimento { get; set; }

        public ContaCorrente(int numero, String titular, double saldo)
            : base (numero, titular,saldo)
        {

        }
        public double rendimento()
        {
            Rendimento = Saldo * 0.03;
            return Rendimento;
        }
    }
}
