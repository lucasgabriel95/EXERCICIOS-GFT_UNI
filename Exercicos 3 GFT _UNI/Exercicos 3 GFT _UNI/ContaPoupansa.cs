using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicos_3_GFT__UNI
{
    class ContaPoupansa : Conta
    {
        private double Rendimento { get; set; }
        public ContaPoupansa(int numero, String titular, double saldo)
          : base(numero, titular, saldo)
        {

        }

        public double rendimento()
        {
            Rendimento = Saldo * 0.05;
            return Rendimento;
        }
    }
}
