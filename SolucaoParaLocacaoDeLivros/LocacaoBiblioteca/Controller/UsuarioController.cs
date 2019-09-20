using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Clase que contem os metodos de validação de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// Login:Admin
        /// Senha: Admin
        /// </summary>
        /// <param name="Usuario">Passamos um objeto de nome Usuário como parametro</param>
        /// <returns>Retorna verdadeiro quando existir usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

        public UsuarioController()
        {
            ListaUsuarios = new List<Usuario>();

            ListaUsuarios.Add(new Usuario()
            {
                Login = "Admin",
                Senha = "Admin"
            });

            ListaUsuarios.Add(new Usuario()
            {
                Login = "Allan",
                Senha = "159753"
            });

        }
        public List<Usuario> ListaUsuarios { get; set; }

    }
}
