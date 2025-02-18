using System;

namespace ExI
{
    class ExI
    {
        static string VerificarPrimo(int numero)
        {
            if (numero <= 1)
            {
                return "false";
            }
            
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return "Não";
                }
            }

            return "Sim";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{numero} é primo? {VerificarPrimo(numero)}");
        }
    }
}