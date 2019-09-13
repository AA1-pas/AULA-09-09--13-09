using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine(Texto());
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }
       
        /// <summary>
        /// Metodo que armazena o texto
        /// </summary>
        /// <returns>retorna o texo</returns>
        private static string Texto ()
        {
            return "O que temos que ter sempre em mente é que a adoção de políticas descentralizadoras aponta para a melhoria da gestão inovadora da qual fazemos parte.";
        }
    }
}
