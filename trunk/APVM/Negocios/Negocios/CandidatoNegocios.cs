using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Repositorio;
using Entidades.Basicas;


namespace Negocios.Negocios
{
    public class CandidatoNegocios
    {
        CandidatoDAO candidatoDAO = new CandidatoDAO();

        public void Inserir(Candidato candidato)
        {
            candidatoDAO.Inserir(candidato);
        }
        public void Atualizar(Candidato candidato)
        {
            candidatoDAO.Atualizar(candidato);
        }
        public void Excluir(Candidato candidato)
        {
            candidatoDAO.Excluir(candidato);
        }
        public List<Candidato> ObterTodos()
        {
            return candidatoDAO.ObterTodos<Candidato>();
        }

        public IQueryable<Candidato> Pesquisar<T>(Func<T, bool> filtro) where T : Candidato
        {
            return this.candidatoDAO.Pesquisar<Candidato>(filtro);
        }

        public T ObterUm<T>(Func<T, bool> filtro) where T : Candidato
        {
            return this.candidatoDAO.ObterUm<T>(filtro);
        }
    }
}
