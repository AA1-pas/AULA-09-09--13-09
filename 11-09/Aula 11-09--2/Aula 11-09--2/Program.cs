using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_09__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaTotal,lado1,lado2;
            Console.WriteLine("Digite o valor do lado 1: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado 2: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            areaTotal = lado1 * lado2;
            Console.WriteLine("O valor da área é de: " + areaTotal);
            Console.ReadKey();
        }
    }
}
