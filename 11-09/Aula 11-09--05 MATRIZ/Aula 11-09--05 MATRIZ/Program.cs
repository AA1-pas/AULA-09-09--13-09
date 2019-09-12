using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_09__05_MATRIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[3] { "Allan", "Ricardo", "Pasquali"};

            string[] arrayLinear2 = new string[2];
            arrayLinear2[0] = "Joao";
            arrayLinear2[1] = "Pedro";

            List<string> listaLinear = new List<string>
            {
                "Renato",
                "Feijão",
                "Gasolina",
                "Maria",
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[2]);
            var keypress = Console.ReadKey();
            var keypress2 = Console.ReadKey().KeyChar.ToString();
          
        }
    }
}
