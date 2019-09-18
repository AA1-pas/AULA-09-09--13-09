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
            MenuPrincipal();
        }

        /// <summary>
        /// Metodo de menu principal de escolha dos metodos
        /// </summary>
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine(@"Qual método você deseja executar?
1-Árvore  
2-Área Quadrado 
3-Lista Cerveja 
4-Lista Marca Carro 

0-Sair
");
            switch(Console.ReadKey().KeyChar.ToString())
            {
                case "1":
                    Console.Clear();
                    DesenhandoArvore();
                    break;
                case "2":
                    Console.Clear();
                    AreaQuadrado();
                    break;
                case "3":
                    Console.Clear();
                    DesenhandoArvore();
                    break;
                case "4":
                    Console.Clear();
                    DesenhandoArvore();
                    break;
                case "0":
                    break;
                default:
                    Console.Clear();
                    RetornaMenu("*** OPÇÃO INVÁLIDA! ***\n\n");
                    break;

            }
            
        }

 
        /// <summary>
        /// Metodo desenha cada linha da arvore
        /// </summary>
        /// <param name="espacador">recebe quantos espacos deve imprimir</param>
        private static void EspacoArvore(double espacador)
        {
            for (int i = 0; i < espacador; i++)
            {
                Console.Write(" ");
            }
        }

        /// <summary>
        /// metodo contem os dados e desenha a arvore
        /// </summary>
        private static void DesenhandoArvore()
        {
            List<int> formatoArvore = new List<int>
            { 4,9,8,14,12,16,13,17,14,15,12,13,10,10,4,4,4,4,4,4,4,4,5,6,8,13,40};

            foreach (var i in formatoArvore)       
            {
                EspacoArvore(40-i);
                DesenhandoALinhaArvore(2*i);
                Console.Write("\n");
            }

            RetornaMenu("");
        }

        /// <summary>
        /// Retorna mesagem de erro se tiver e volta ao menu principal ao apertar qualquer tecla
        /// </summary>
        /// <param name="menssagemErro">menssagem de advertencia ao usuário</param>
        private static void RetornaMenu(string menssagemErro)
        {
            Console.WriteLine(menssagemErro + "Tecle qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();
            MenuPrincipal();
        }
        
        /// <summary>
        /// Metodo desenha cada linha da arvore
        /// </summary>
        /// <param name="espacador">recebe quantos caracteres deve imprimir</param>
        private static void DesenhandoALinhaArvore(int espacador)
        {
            for (int i = 0; i < espacador; i++)
            {
                Console.Write(".");
            }
        }

        /// <summary>
        /// Metodo calcula área quadrado
        /// </summary>
        private static void AreaQuadrado()
        {
            Console.WriteLine("Digite a medida do lado do quadrado (cm).");
            double ladoQuadrado = double.Parse((Console.ReadLine()));
            Console.WriteLine("\n"+$"A área do quadrado é de {ladoQuadrado* ladoQuadrado} cm²."+"\n");
            RetornaMenu("");
        }
    }
}
