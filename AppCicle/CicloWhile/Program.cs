using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();
            string nome = string.Empty;
            int idade = 0;
            string genero = string.Empty;
            while (AskToContinue() == "1")
            {
                nome = AskToName();
                idade = AskToAge();
                genero = AskToGenero();
            }
            Console.WriteLine($"\n\nSuas informações: \nNome: {nome} \nIdade: {idade} \nGênero: {genero}");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserrido</returns>
        private static string AskToContinue()
        {
            Console.WriteLine("\nVamos conversar? Sim(1) Não(2)");
            return  Console.ReadKey().KeyChar.ToString();
            //return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

        /// <summary>
        /// Metodo para realizar a pergunta idade
        /// </summary>
        /// <returns>retorna idade</returns>
        private static int AskToAge ()
        {
            Console.WriteLine("Quantos anos você têm?");
            int idade = int.Parse(Console.ReadLine());
             return (idade);
        }

        /// <summary>
        /// Método para mostrar o texto inicial do sistema "Bem vindo"
        /// </summary>
        private static void ShowInitAppText ()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }

        /// <summary>
        /// Metodo para perguntar nome
        /// </summary>
        /// <returns>retorna o nome perguntado</returns>
        private static string AskToName ()
        {
            Console.WriteLine("\nQual seu nome?");
            return Console.ReadLine();

        }

        /// <summary>
        /// Metodo para perguntar genero
        /// </summary>
        /// <returns>retorna o genero perguntado</returns>
        private static string AskToGenero()
        {
            Console.WriteLine("Qual seu genero? Masculino (M) Feminino (F)");
            return Console.ReadLine();

        }
    }
}
