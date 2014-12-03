using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Repositorio;
using Entidades.Basicas;

namespace Negocios.Negocios
{
    public class VagaNegocios
    {

        VagaDAO vagaDAO = new VagaDAO();
        public void Inserir(Vaga vaga)
        {
            vagaDAO.Inserir(vaga);
        }

        public void Atualizar(Vaga vaga)
        {
            vagaDAO.Atualizar(vaga);
        }

        public void Excluir(Vaga vaga)
        {
            vagaDAO.Excluir(vaga);
        }

        public List<Vaga> ObterTodos()
        {
            return vagaDAO.ObterTodos<Vaga>();
        }
    }
}
