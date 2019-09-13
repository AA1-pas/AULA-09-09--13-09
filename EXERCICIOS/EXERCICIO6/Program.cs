using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO6
{
    class Program
    {

        static void Main(string[] args)
        {
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            BananaLaranja();
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo troca a palava banana por laranja
        /// </summary>
        private static void BananaLaranja()
        {
            Console.WriteLine("Digite seu texto: ");
            Console.WriteLine("\n\n Seu novo texto segue abaixo:\n\n " + Console.ReadLine().Replace("banana","laranja"));
        }
    }
}