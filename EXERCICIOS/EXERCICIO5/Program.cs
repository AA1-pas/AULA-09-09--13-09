using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    class Program
    {

        static void Main(string[] args)
        {
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            FirstLastChar();
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para pegar o primeiro e ultimo caracter de uma palavra
        /// </summary>
        private static void FirstLastChar()
        {
            Console.WriteLine("Digite sua palavra: ");
            string word = Console.ReadLine();
            Console.WriteLine($"A primeira letra da sua palavra é '{word[0]}' e a última letra é '{word[word.Length-1]}'.");
        }
    }
}