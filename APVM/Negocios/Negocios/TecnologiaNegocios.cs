using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados.Repositorio;
using Entidades.Basicas;

namespace Negocios.Negocios
{
    public class TecnologiaNegocios
    {
        TecnologiaDAO tecnologiaDAO = new TecnologiaDAO();

        public void Inserir(Tecnologia tecnologia)
        {
            tecnologiaDAO.Inserir(tecnologia);
        }

        public void Atualizar(Tecnologia tecnologia)
        {
            tecnologiaDAO.Atualizar(tecnologia);
        }

        public void Excluir(Tecnologia tecnologia)
        {
            tecnologiaDAO.Excluir(tecnologia);
        }

        public List<Tecnologia> ObterTodos()
        {
            return tecnologiaDAO.ObterTodos<Tecnologia>();
        }



    }
}
