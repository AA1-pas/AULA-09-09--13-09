using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            nomeCompleto = NomeFind();
            Console.WriteLine($"\n********** Seja muito bem Vindo {nomeCompleto}! **********");
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para ler o nome
        /// </summary>
        /// <returns>retorna o nome</returns>
        private static string NomeFind()
        {
           Console.WriteLine("Digite seu nome completo: ");
            return (Console.ReadLine());
        }
    }
}
