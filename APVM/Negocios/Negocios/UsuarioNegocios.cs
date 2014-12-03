using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Repositorio;
using Entidades.Basicas;

namespace Negocios.Negocios
{
    public class UsuarioNegocios
    {

        UsuarioDAO usuarioDAO = new UsuarioDAO();

        public void Inserir(Usuario usuario)
        {
            usuarioDAO.Inserir(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            usuarioDAO.Atualizar(usuario);
        }

        public void Excluir(Usuario usuario)
        {
            usuarioDAO.Excluir(usuario);
        }

        public List<Usuario> ObterTodos()
        {
            return usuarioDAO.ObterTodos<Usuario>();
        }

    }
}
