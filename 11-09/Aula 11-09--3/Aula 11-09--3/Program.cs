﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_09__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma sequencia de numeros: ");
            var textContent = Console.ReadLine();

            Console.WriteLine(textContent.Replace("3", "Banana"));
            Console.ReadKey();
        }
    }
}
