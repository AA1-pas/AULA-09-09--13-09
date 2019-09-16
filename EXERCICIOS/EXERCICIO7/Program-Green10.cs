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
            
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("Digite seu texto: ");
            string text = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($@"Esse texto possue {ContaVogais("a", "A", text)} vogai(s) 'A', {ContaVogais("e", "E" , text)} vogai(s) 'E', 
{ContaVogais("i", "I", text)} vogai(s) 'I', {ContaVogais("o", "O", text)} vogai(s) 'O' e {ContaVogais("u","U", text)} vogai(s) 'U'. ");
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo conta quantas vogais tem no texto
        /// </summary>
        /// <param name="vogal">vogal para contar no texto</param>
        /// <param name="textFind">texto para procurar a vogal</param>
        /// <returns></returns>
        private static int ContaVogais(string vogal, string vogalMaiu, string textFind)
        {
            string[] stringFind = new string[] { vogal };
            string[] quebraMin = textFind.Split(stringFind, StringSplitOptions.None);
            string[] stringFind2 = new string[] { vogalMaiu };
            string[] quebraMaiu= textFind.Split(stringFind2, StringSplitOptions.None);
            var numberFind = quebraMin.Length - 1+(quebraMaiu.Length - 1);
            return numberFind;

        }
    }
}