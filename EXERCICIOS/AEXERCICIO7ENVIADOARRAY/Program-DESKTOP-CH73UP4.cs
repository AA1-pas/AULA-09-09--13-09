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

            int[] valores = new int[10];
            string[] stringFind = new string[] { "A", "E", "I", "O", "U" };
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("\n");
            valores = ContaVogais();
            for (int i = 0; i < 5; i++)
            {
                valores[i] += valores[i + 5];
                Console.WriteLine($"A quantidade de letras {stringFind[i]} é de {valores[i]}. ");
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
            int[] numberFind = new int[15];
            Console.WriteLine("Digite seu texto: ");
            string text = Console.ReadLine();
            string[] stringFind2 = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < stringFind2.Length; i++)
            {
                string[] stringFind = {stringFind2[i]};
                string[] quebraMaiu = text.Split(stringFind, StringSplitOptions.None);
                int cont = quebraMaiu.Length - 1;
                numberFind[i] = cont;
            } 
            return numberFind;

        }
    }
}