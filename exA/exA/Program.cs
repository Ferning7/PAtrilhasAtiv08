
using System;

namespace exA
{
	class Program
	{
		static double Quadrado(int n){
			return Math.Sqrt(n);
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número para calcular raiz quadrada");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine("a Raiz quadrada de {0} será {1}", num, Quadrado(num));
			Console.WriteLine(Math.Sqrt(4));
			
			Console.ReadKey(true);
		}
		
		
		
	}
}