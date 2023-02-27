using ProjectFitness.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFitness.Interfaces_e_Respositorios
{
   public interface IRepositorioUsuario
    {
        int ObterTotalDeUsuarios();

        bool AdicionarUsuario(Usuario usuario);

        void AtualizarUsuario(Usuario usuario);

        void ExcluirUsuario(int usuarioId);

        Usuario[] ObterTodosUsuario();

        Usuario ObterPorLogin(string login);

        bool AutenticarUsuario(string login, string senha);
    }
}
