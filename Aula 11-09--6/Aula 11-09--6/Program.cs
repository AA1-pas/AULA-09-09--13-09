using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_09__6
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = "alguma coisa mais " +
                "alguma informação aqui";
            var teste1 = "alguma coisa mais \r\n alguma informação aqui";

            var teste2 = @"alguma coisa mais 
alguma informação aqui";

            var teste3 = Console.ReadLine();
            var teste4 = Console.ReadLine();
            var teste5 = teste3 + teste4;

            Console.WriteLine(teste5);


            /**/

            var testeTemplate = @"Nome do usuario:{0}
Idade:{1}
Descrição:{2}
Nome de Novo:{0}";

            var finishText = string.Format(testeTemplate
                , Console.ReadLine()
                , Console.ReadLine()
                , Console.ReadLine());

            Console.WriteLine(finishText);
            
            /**/

            Console.WriteLine("\r\n");
            Console.WriteLine(teste);
            /*Console.WriteLine(teste2);*/
            Console.ReadKey();
        }
    }
}
