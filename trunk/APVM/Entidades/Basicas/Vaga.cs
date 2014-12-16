using Entidades.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basicas
{
    public class Vaga : Entidade
    {
        public string Descricao { get; set; }
        public virtual List<Tecnologia> PreRequisitos { get; set; }
        public string Resumo { get; set; }
        private int? Nivel { get; set; }
        public DateTime Validade { get; set; }
        public int Status { get; set; }
        public Nivel? NivelEnum
        {
            get { return (Nivel?)NivelEnum; }
            set { Nivel = (int?)value; }
        }
    }
}
