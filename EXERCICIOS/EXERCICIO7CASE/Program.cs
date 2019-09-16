using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO7
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] stringFind = new string[] {"A", "E", "I", "O", "U" };
            Console.WriteLine("*****************************");
            Console.WriteLine("***** Seja bem Vindo!!! *****");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("\n");
            var valores = ContaVogais();
            for (int i = 0; i < 5; i++)
            {
                valores[i] += valores[i + 5];
                Console.WriteLine($"A quantidade de letras {stringFind[i]} é de {valores[i]}.");
            }
            Console.WriteLine("\n\nAperte qualquer tecla para sair.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo conta quantas vogais tem no texto
        /// </summary>
        /// <returns>Retorna array com as quantidades de vogais</returns>
        private static int[] ContaVogais()
        {
            int[] numberFind = new int[10];
            Console.WriteLine("Digite seu texto: ");
            string text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas eget nibh at ante suscipit accumsan et nec nibh. Suspendisse eu lacinia nulla. Curabitur mollis lectus a efficitur gravida. Etiam nisi dui, facilisis sed commodo in, consequat sit amet lectus. Cras suscipit, lacus nec pulvinar elementum, sem erat condimentum eros, a facilisis mauris nisl ut quam. Quisque in rhoncus enim. Vestibulum lorem ligula, porttitor eu tortor a, dictum euismod lectus. Pellentesque aliquam nunc rutrum commodo bibendum. Sed maximus, neque eget placerat faucibus, nisi nisl ultricies turpis, et pretium neque lacus eu felis. Aenean semper condimentum velit id finibus. Morbi viverra tellus est, et hendrerit dui commodo a. In tincidunt sapien purus, eget mollis velit posuere lobortis. Mauris tempus vestibulum ex, et feugiat lorem mollis mattis. In volutpat egestas mauris at porta. Aliquam rutrum commodo gravida.

Praesent imperdiet enim non tempus lacinia. Maecenas consectetur porttitor lacus in pharetra. In hac habitasse platea dictumst. Curabitur finibus lectus ut metus mollis, ut egestas erat eleifend. Donec eleifend ultricies neque, sit amet tincidunt ex. Sed hendrerit tristique dignissim. Phasellus fringilla, purus ut malesuada fringilla, risus sem eleifend nulla, in commodo lectus neque et leo. Quisque iaculis, est eu porttitor consequat, lorem leo egestas erat, nec molestie odio arcu eu magna. Aenean posuere rhoncus justo sit amet efficitur. Proin imperdiet blandit ligula vel condimentum. Mauris fermentum, sapien eget ullamcorper lobortis, quam urna facilisis mauris, quis aliquet ipsum mi et metus. Donec tempor nisl efficitur, imperdiet metus volutpat, interdum augue. Donec commodo pellentesque lobortis. Etiam luctus consequat urna, eu dapibus nibh. Pellentesque consectetur, nulla blandit facilisis ornare, massa ligula vestibulum nibh, vel dignissim velit mi vel urna.

Integer quis massa vel mi vestibulum interdum et ac dolor. Etiam sit amet lectus ut sem feugiat pretium. Aliquam erat volutpat. Nulla dictum nisl libero, sit amet ultricies nisi fermentum at. Integer in eros ut nunc aliquet imperdiet. Vivamus congue interdum euismod. Vestibulum vel elit in eros varius dapibus a vel metus. Vivamus mi sapien, aliquam eget velit et, aliquet congue est. Nulla vestibulum faucibus ex eget auctor. In hac habitasse platea dictumst. Nulla ullamcorper augue enim, vel condimentum orci iaculis at. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Suspendisse faucibus iaculis justo vitae fermentum. Cras tempus, urna nec eleifend cursus, ex tortor fermentum nunc, ac ultricies risus ligula eget ex. Fusce feugiat nulla sed ornare vehicula. Phasellus luctus dictum ante, faucibus placerat neque euismod eget.

Nulla a sem semper, cursus velit et, suscipit magna. Integer a diam gravida lacus fringilla rhoncus. Praesent finibus quam ac rutrum imperdiet. In iaculis semper neque nec auctor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam efficitur condimentum fringilla. Nulla sodales, tortor nec commodo maximus, lectus sem hendrerit nulla, eget cursus quam ipsum at nulla. Aliquam eget urna sodales, euismod neque ut, congue massa. Etiam ultricies enim nisl, vel sagittis nisi imperdiet aliquam. Donec molestie tempor suscipit. In hac habitasse platea dictumst. Phasellus venenatis blandit purus at condimentum. In egestas congue urna, id feugiat lectus ornare vel. Cras rhoncus, velit et finibus luctus, ligula mi dapibus est, at faucibus arcu purus in urna.

Suspendisse in tempor mauris. Nullam dignissim vestibulum urna vel venenatis. Vestibulum ornare nunc ac purus volutpat, id dapibus magna porta. Sed luctus, nunc eget blandit commodo, lorem massa auctor odio, vel gravida arcu dui eleifend purus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Maecenas euismod efficitur ante, mattis facilisis orci suscipit in. Quisque quis egestas arcu. Morbi semper elit aliquet placerat mattis. In ac lacinia lorem. Mauris ipsum lacus, laoreet et est cursus, tincidunt euismod magna. Aliquam a posuere mauris, quis semper lacus. In euismod viverra sem nec posuere.

Aenean nec velit diam. Aliquam sagittis dui vitae congue aliquam. Aliquam congue sapien diam, eget cursus eros porttitor vel. Ut quis nunc consectetur, faucibus nulla at, tempor turpis. Sed cursus sapien magna, quis fringilla arcu aliquet a. Maecenas ultricies blandit tincidunt. Nam in sem ligula. Cras bibendum id metus sed viverra. Pellentesque rhoncus posuere urna id blandit.

Curabitur pharetra nibh eu condimentum egestas. Proin non luctus justo. Suspendisse nec sapien a orci efficitur consectetur vel et neque. Donec placerat ipsum in ante dignissim, ut consequat nibh interdum. Duis vehicula facilisis sem in porttitor. Praesent ligula augue, iaculis at semper vitae, facilisis sit amet magna. Proin pellentesque convallis urna, non bibendum metus bibendum nec. Phasellus vestibulum dictum libero, eu viverra lacus bibendum quis. Duis tincidunt mi sed nunc fringilla consectetur. Pellentesque eu massa ac sapien posuere molestie et vel ante. Praesent iaculis tellus ac magna tristique congue. Ut blandit, massa a aliquam gravida, sem tortor sagittis ligula, vel accumsan sapien est ac lacus.

Proin sit amet dictum nulla, posuere sodales nisl. Nullam porttitor ultrices leo sit amet tincidunt. Donec sollicitudin sit amet orci et vehicula. Suspendisse consectetur eros quis interdum suscipit. Vestibulum malesuada, purus eget pulvinar sollicitudin, magna nisi condimentum lacus, non consectetur tortor augue id odio. Donec sit amet mauris in purus fringilla tincidunt et vel justo. Maecenas lobortis eu nisl at euismod. Aenean in blandit justo. Integer porttitor quam vitae nisl lobortis interdum. Sed nec eleifend ligula. Maecenas tempus urna in nisl laoreet sollicitudin. Sed vehicula id nulla sit amet luctus. Sed euismod mi et dignissim rutrum. Proin mollis dui mauris, vitae iaculis sem condimentum sed.

Morbi convallis mattis lorem, vel egestas metus aliquam non. Maecenas eget eros ultricies, tristique nisl sit amet, viverra mi. Donec lectus sem, pretium non mauris ut, pellentesque faucibus ante. Fusce pretium sapien leo, non mattis metus pharetra quis. Fusce et ipsum mauris. Maecenas id placerat dolor, vel facilisis tellus. Morbi sit amet mi imperdiet, consequat lorem vitae, aliquam lectus. Aenean tristique ullamcorper condimentum.

Sed in mi mi. In elementum elit eu consectetur accumsan. Etiam laoreet egestas eleifend. Aliquam sagittis sodales viverra. Quisque sem ex, aliquet eu est in, ullamcorper euismod felis. Nullam efficitur ultricies odio, sed molestie elit congue non. Duis id lectus fringilla, maximus purus non, tristique augue. Mauris nisl diam, pellentesque sit amet aliquet sit amet, dignissim a quam. Nunc turpis augue, sagittis porttitor sem vel, aliquam ornare mauris. Vivamus eget risus sit amet felis tristique ultrices. Curabitur tempus turpis eget velit ullamcorper, non fermentum erat posuere. Suspendisse nisl ligula, volutpat eget metus at, rutrum fringilla justo.";
            char[] stringFind2 = new char[] { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};
            for (int i = 0; i < stringFind2.Length; i++)
            {
                string[] quebraLinha = text.Split(stringFind2[i]);
                numberFind[i] = quebraLinha.Length - 1;
            }
            return numberFind;

        }
    }
}