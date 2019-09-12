using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            string stringTotal = string.Empty;
            List<int> listaLinear = new List<int> { };
            while (i <= 10000000)
            {
                int j = 2;
                while (j < i && i % j != 0)
                    j++;
                if (i == j)
                    listaLinear.Add(i);
                i++;
            }
            /*for (i=0; i<(listaLinear.Count); i++)
            {
                stringTotal += "\n" + (Convert.ToString(listaLinear[i]));
            }
            foreach (int primos in listaLinear)
            {
                Console.WriteLine($"{primos}");
            }
            Console.WriteLine(stringTotal);*/
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
