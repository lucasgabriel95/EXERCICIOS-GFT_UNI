using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Exercicos_GFT_UNI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Vamos verificar os numeros impares existentes em um intervalor ---");
            Console.WriteLine("Por favor digite o numero inicial");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor digite o numero final");
            int valor2 = int.Parse(Console.ReadLine());

            List<int> Impares = new List<int>();

            for (int i = valor1; i <= valor2; i++)
            {
                int impar = i% 2;

                if (impar != 0)
                {
                    Impares.Add(i);
                }
            }

            Console.WriteLine("Os valores são: ");
            Impares.ForEach(Console.WriteLine);

            
        }
    }
}
