using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basicas
{
    public class Candidato
    {
        public long CandidatoId { get; set; }
        public byte[] Curriculo { get; set; }
        public virtual Vaga Vaga { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
