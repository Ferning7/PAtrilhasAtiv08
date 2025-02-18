using System;

namespace exG
{
    class ExG
    {
        static string CaracteresPosicoesImpares(string input)
        {
            string resultado = "";
            for (int i = 1; i < input.Length; i += 2)
            {
                resultado += input[i];
            }
            return resultado;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            
            Console.WriteLine($"Em posições ímpares: {CaracteresPosicoesImpares(palavra)}");
        }
    }
}