using System;
using System.Collections.Generic;

namespace exH
{
    class ExH
    {
        static double MediaLista(List<int> numeros)
        {
            if (numeros.Count == 0)
            {
                return 0;
            }
            
            double soma = 0;
            
            foreach (var numero in numeros)
            {
                soma += numero;
            }
            
            return soma / numeros.Count;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Inserindo lista de numeros");
            Console.WriteLine("Digite 4 números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            
            List<int> numeros = new List<int>{num1, num2, num3, num4};
            
            Console.WriteLine($"A média dos números inseridos é:{MediaLista(numeros)}");
        }
    }
};