using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Util;

namespace Entidades.Basicas
{
    public class Candidato : Entidade
    {
        public byte[] Curriculo { get; set; }
        public virtual Vaga Vaga { get; set; }
        public long VagaId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public long UsuarioId { get; set; }
        public DateTime DataCadastro { get; set; }
        private int Status { get; set; }
        public int Situacao { get; set; }
        public Situacao SituacaoEnum
        {
            get { return (Situacao)SituacaoEnum; }
            set { Situacao = (int)value; }
        }
    }
}
