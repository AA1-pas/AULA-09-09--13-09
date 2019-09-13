using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "John", "Tom", "Peter" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
