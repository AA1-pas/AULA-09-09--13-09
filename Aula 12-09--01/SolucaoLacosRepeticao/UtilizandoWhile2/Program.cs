using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while(count<10000000)
            {
                //Console.WriteLine($"Número: {count}");
                count+=5;
                count++;
                count = count+3;
            }
            Console.WriteLine("Terminou o loop");
            Console.ReadKey();
        }
    }
}
