using CestaFruta2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhaCestaDeFrutas = new List<MinhasFrutas>();
            {
                minhaCestaDeFrutas.Add(new Fr()
                {
                    Banana = 6,
                    Laranja = 10,
                    Tomate = 3
                });

                listaDeCestas.ForEach(i =>
                Console.WriteLine($"Banana {i.Banana} tomate {i.Tomate} laranja {i.Laranja}"));
                Console.ReadKey();
            }
        }
    }
}
