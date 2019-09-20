using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        //instanciamos "Carregamos para memoria"nosso controlador de livros
        static LivrosController livros = new LivrosController();
       
        //instanciamos "Carregamos para memoria"nosso controlador de usuários
        static UsuarioController listaUsuarios = new UsuarioController();

        static void Main(string[] args)
        {
            while (!RealizaLoginSistema())
            {
                Console.WriteLine("*** LOGIN E SENHA INVÁLIDOS ***\n");
                Console.ReadKey();
            }
            MostraMenuSistema();
        }

        /// <summary>
        /// MOstra no console o menu disponível do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {

            int opcao = int.MinValue;
            while (opcao != 9)
            {
                Console.Clear();
                CabecalhoPrograma();
                Console.WriteLine("=================== MENU SISTEMA ====================\n");
                Console.WriteLine("1 - Listar Usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("8 - Voltar ao login");
                Console.WriteLine("9 - Sair");
                Console.Write("\nOpção: ");
                //Aqui vamos pegar numero digitado
                //Executar proxima funcao
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcao);
                switch (opcao)
                {
                    case 1:
                        MostraUsuarios();
                        break;
                    case 2:
                        MostraLivros();
                        break;
                    case 8:
                        while (!RealizaLoginSistema())
                        {
                            Console.WriteLine("*** LOGIN E SENHA INVÁLIDOS ***\n");
                            Console.ReadKey();
                        }
                       
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Metodo que realiza os procedimentos completo de login dentro do sistema
        /// como solicitação de login e senha pelo console assim como a respectiva 
        /// validação que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>
        /// Retorna verdadeiro quando o login e senha informados 
        /// estiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            Console.Clear();
            CabecalhoPrograma();
            Console.WriteLine("=============== AUTENTICAÇÃO SISTEMA ================\n");
                               
            Console.WriteLine("Informe seu login e senha para acessar o sistema:\n");

            Console.Write("Login: ");
            var loginDoUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(new Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });
        }

        /// <summary>
        /// Metodo instancia o objeto Livro e mosta 1 registro
        /// </summary>
        private static void MostraLivros()
        {
            Console.Clear();
            CabecalhoPrograma();
            Console.WriteLine("============ LISTA DE LIVROS CADASTRADOS ============\n");
            livros.Livros.ForEach(i => Console.WriteLine($"Nome: {i.Nome} \nId: {i.Id}\n--------------------\n"));
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo instancia o objeto Usuarios e mosta registros
        /// </summary>
        private static void MostraUsuarios()
        {
            Console.Clear();
            CabecalhoPrograma();
            Console.WriteLine("=========== LISTA DE USUARIOS CADASTRADOS ===========\n");
            listaUsuarios.ListaUsuarios.ForEach(i => Console.WriteLine($"Nome: {i.Login} \nId: {i.Id}\n--------------------\n"));
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo apresenta o cabeçalho padrão no console
        /// </summary>
        private static void CabecalhoPrograma()
        {
            Console.WriteLine(".....................................................\n");
            Console.WriteLine("********* SISTEMA DE LOCAÇÃO DE LIVROS V1.0 *********");
            Console.WriteLine(".....................................................\n");
        }

        //// Metodo para retornar lista
        //private static List<Livro> CadastraLivros()
        /*{
        //    List<Livro> livro = new List<Livro>();
        //
        //    livro.Add(new Livro()
        //    {
        //        Nome = "A bela e a Fera",
        //        Id = 1589
        //    });
        //    return livro;
        //}

        //private static void MostraLivros(List<Livro> listaImprimir)
        //{
        //    listaImprimir.ForEach(i => Console.WriteLine($"Nome {i.Nome} \nId {i.Id}\n--------------------\n"));
        }*/

    }
}
