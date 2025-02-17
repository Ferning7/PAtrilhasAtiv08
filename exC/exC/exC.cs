using System;

namespace exC
{
    class Program
    {
        static int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"A soma de {num1} + {num2}: {somar(num1, num2)}");
        }
    }
}




