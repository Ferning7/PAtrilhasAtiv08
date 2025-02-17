using System;
using System.Collections.Generic;

namespace exD
{
    class exD
    {
        static int ListaMaiorNumero(List<int> ListaNumeros)
        {
            int maiorNumero = ListaNumeros[0];
            
            foreach (int numero in ListaNumeros)
            {
                if (numero > ListaNumeros.Max())
                {
                    maiorNumero = numero;
                }
            }
            return maiorNumero;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            
            List<int> ListaNumeros = new List<int>{num1, num2, 5, 10, 15, 20, 25, 30, 35, 45};
            int ListaMaiorNumero = ListaNumeros.Max();

            Console.WriteLine($"O maior número da lista é: {ListaMaiorNumero}");
        }
    }
}

