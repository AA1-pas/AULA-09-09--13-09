using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO7
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = string.Empty;
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("Digite seu texto: ");
            text = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($@"Esse texto possue {ContaVogais("a", text)} vogai(s) 'a', {ContaVogais("e", text)} vogai(s) 'e', 
{ContaVogais("i", text)} vogai(s) 'i', {ContaVogais("o", text)} vogai(s) 'o' e {ContaVogais("u", text)} vogai(s) 'u'. "); 
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo conta quantas vogais tem no texto
        /// </summary>
        /// <param name="vogal">vogal para contar no texto</param>
        /// <param name="textFind">texto para procurar a vogal</param>
        /// <returns></returns>
        private static int ContaVogais(string vogal, string textFind)
        {
            string[] stringFind = new string[] {vogal};
            string[] firstNames = textFind.Split(stringFind, StringSplitOptions.None);
            var numberFind = firstNames.Length - 1;
            return numberFind;
          
        }
    }
}