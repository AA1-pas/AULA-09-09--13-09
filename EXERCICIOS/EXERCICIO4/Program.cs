using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO4
{
    class Program
    {

        static void Main(string[] args)
        {
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine($"\nA quantidade de caracteres é de {Texto()} caracteres.\n\n");
            Console.WriteLine("Aperte qualquer tecla para sair.");
            Console.ReadKey();
        }

       /// <summary>
       /// Metodo para ler o texto e contar caracteres
       /// </summary>
       /// <returns>quantidade de caracteres</returns>
        private static int Texto ()
        {
            Console.WriteLine("Digite seu texto: ");
            var quantidade = Console.ReadLine().Length;
            return quantidade;
        }
    }
}