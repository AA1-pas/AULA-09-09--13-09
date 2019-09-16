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
            string[] stringFind = new string[] {"A", "E", "I", "O", "U" };
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("\n");
            var valores = ContaVogais();
            for (int i = 0; i < 5; i++)
            {
                valores[i] += valores[i + 5];
                Console.WriteLine($"A quantidade de letras {stringFind[i]} é de {valores[i]}.");
            }
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo conta quantas vogais tem no texto
        /// </summary>
        /// <returns>Retorna array com as quantidades de vogais</returns>
        private static int[] ContaVogais()
        {
            int[] numberFind = new int[10];
            Console.WriteLine("Digite seu texto: ");
            string text = Console.ReadLine();
            char[] stringFind2 = new char[] { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};
            for (int i = 0; i < stringFind2.Length; i++)
            {
                string[] quebraLinha = text.Split(stringFind2[i]);
                numberFind[i] = quebraLinha.Length - 1;
            }
            return numberFind;

        }
    }
}