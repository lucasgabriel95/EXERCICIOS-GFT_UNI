using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_2_GFT_UNI
{
    class Pessoa
    {
        private String Nome { get; set; }
        private String Endereco { get; set; }
        private String Telefone { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }


        public override string ToString()
        {
            return "Nome: " + Nome + " Endereço: " + Endereco + " Telefone: " + Telefone;
        }
    }
}
