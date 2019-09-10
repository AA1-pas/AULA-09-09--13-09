using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Texto informativo para consultar o livro pelo numero de registro do sistema
            Console.WriteLine("Informe o livro a ser consultado: ");
            //Parte do codigo que recebe as informações de registro do livro e coloca
            //na variavel numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            //Aqui realizo a comparação das informações do livro informado com o que tenho
            //disponível em estoque
            if (numeroDoLivro=="159")
            {
                Console.WriteLine("Livro disponível!!!");
            }
            else
            {
                Console.WriteLine("Livro não disponível!!!");
            }
            Console.ReadKey();
        }
    }
}
