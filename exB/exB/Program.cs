
using System;

namespace exA
{
	class Program
	{
		
		static int NumCaracteres(string word){
			return word.Length;
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma palavra:");
			string palavra = Console.ReadLine(); 
			
			Console.WriteLine("A palavra '{0}' contém {1} letras", palavra, NumCaracteres(palavra));
			
			
			
			Console.ReadKey(true);
			
			
		}
		
		
		
	}
}