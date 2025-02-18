using System;
using System.Collections.Generic;
using System.Linq;

namespace exF
{
    class ExF
    {
        static bool VerificarPar(int numero)
        {
            return numero % 2 == 0;
        }

        public static void Main()
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"{VerificarPar(num)}");
        }
    }
}