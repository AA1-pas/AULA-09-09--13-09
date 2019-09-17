using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOEXERCICIO1709
{
    class Program
    {
        static void Main(string[] args)
        {
            DesenhoArvore();
        }

        public static void DesenhoArvore()
        {
            for (int i = 0; i < 8; i++)
            {
                int espaco = 10;
                for (int j = 0; j < espaco; j++)
                {
                    if (j%2 == 0)
                    Console.Write(" ");
                    else
                    Console.Write("     ");
                }
                Console.Write("*");
                Console.Write("\n"); 

            }
            Console.ReadKey();
        }
    }
}
