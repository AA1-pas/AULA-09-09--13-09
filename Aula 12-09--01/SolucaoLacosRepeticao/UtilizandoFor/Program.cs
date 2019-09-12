using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Allan Ricardo Pasquali Allan";
            var countFind = 0;
            for (int i = 0; i < 22; i++)
            {
                Console.WriteLine(nome[i]);
            }

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{nome[i-1]}|{nome[i]}|{nome[i+1]}");
                if ((nome[i - 1].ToString() + nome[i].ToString()) == "ll")
                    countFind++;
            }
            Console.WriteLine($"Quantidade total de 'll' {countFind}");

            for (int i = 1; i < 21; i++)
            {
                var stringBuiler = $"{nome[i - 1]}|{nome[i]}|{nome[i + 1]}";
                Console.WriteLine(stringBuiler);
                if (stringBuiler.Contains("l|a"))
                    countFind++;
            }
            Console.WriteLine($"Quantidade total de 'l|a' {countFind}");
            Console.ReadKey();
        }
    }
}
