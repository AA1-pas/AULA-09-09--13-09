using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11_09___1
{
    class Program
    {
        const int testeConst = 999;
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informar o nome a ser calculado: ");
            var nomeLenght = Console.ReadLine();
            Console.WriteLine($"O tamanho deste nome é: {nomeLenght.Length}");
            Console.WriteLine($"O tamanho deste nome é: {nomeLenght.Replace(" ","").Length}");
            Console.WriteLine("O tamanho deste nome é: " + nomeLenght.Replace(" ", "").Length);


            String teste7 = string.Empty;
            var teste6 = String.Empty;
            int numeroInteiro = 999; // até 2.147.483.647;
            long numeroLongo = 151515111515; // até 9223372036854775807
            float numeroFloat = 51518181818181888; // até -3.4E+38 to +3.4E+38
            double numeroDouble = 2525181825151745555;    // até -1.7E+308 to +1.7E+308
            bool testComp = "123" == "123";
            bool? testeBoolNull;
            Boolean testeComp = "123" == "123";
            var teste1 = "String";
            var teste2 = 'C';
            var teste3 = 3;
            var teste4 = 4.28;
            var teste5 = 0x0A;
            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
    }
}
