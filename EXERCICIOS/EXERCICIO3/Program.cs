using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    class Program
    {

        static void Main(string[] args)
        {
            string nomeCompleto = string.Empty;
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Idade(Nome());
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }
     
        /// <summary>
        /// Metodo para perguntar nome
        /// </summary>
        /// <returns>Retorna o nome</returns>
        private static string Nome()
        {
            Console.WriteLine("Digite seu nome completo: ");
            return (Console.ReadLine());
        }

        /// <summary>
        /// Metodo para verificar a idade e escrever 
        /// </summary>
        /// <param name="nome">Argumento que recebe o nome</param>
        private static void Idade(string nome)
        {
            Console.WriteLine("Digite sua idade: ");
            if (int.Parse(Console.ReadLine()) >= 18)
                Console.WriteLine($"\nParabéns {nome} você já esta na fase adulta.");
            else
                Console.WriteLine($"\nCalma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");            
        }
    }
}