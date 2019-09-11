using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_09__4
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Ola eu Allan, estou aqui ainda sendo o Allan, ainda na estrada Rua Allan. Amanhã ainda vou ser o Allan e depois ainda seria o Allan, e depois e depois.";
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");
            primeiroTexto = primeiroTexto.Replace("Allan", "1").Replace("ainda", "2").Replace("depois", "3");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");
            primeiroTexto = primeiroTexto.Replace("1", "Allan").Replace("2", "ainda").Replace("3", "depois");
            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contem: {primeiroTexto.Length} caracteres.");
            Console.ReadLine();
        }
    }
}
