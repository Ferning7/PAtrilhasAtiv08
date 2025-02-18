using System;
using System.Collections.Generic;
using System.Net;

namespace ExJ
{
    class ExJ
    {
        static int MenorNumero(List<int> numeros)
        {
            return numeros.Min();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Insira valores em uma lista (digite 'sair') para sair'");
            List<int> numeros = new List<int>();
            
            while (true)
            {
                Console.Write("Digite um numero: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "sair")
                {
                    break;
                }
                if (int.TryParse(userInput, out int numero))
                {
                    numeros.Add(numero);
                }
                
            }
            Console.WriteLine($"O menor número: {MenorNumero(numeros)}");
            
           
        }
    }
}