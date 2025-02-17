using System;
using System.Collections.Generic;

namespace exE
{
    class exE
    {
        static string ListaStrings(List<string> listaStrings)
        {
           string resultado = string.Join(" ", listaStrings);
           
           return resultado;
        }

        public static void Main(string[] args)
        {
            List<string> listaStrings = new List<string>{"Concatenando", "a", "frase"};
            
            string resultado = ListaStrings(listaStrings);
            
            Console.WriteLine($"A Lista concatenada: {resultado}");
        }
        
    }
}

