using System;

namespace Exercicios_2_GFT_UNI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Vamos cadastrar seus dados ---");
            Console.Write("--- Digite seu nome completo: ");
            string Nome = Console.ReadLine();
            Console.Write("--- Digite seu endereço: ");
            string Endereco = Console.ReadLine();
            Console.Write("--- Informe Seu telefone:  ");
            string Telefone = Console.ReadLine();

            Pessoa pessoa = new Pessoa(Nome, Endereco, Telefone);

            Console.WriteLine(pessoa);


        }
    }
}
