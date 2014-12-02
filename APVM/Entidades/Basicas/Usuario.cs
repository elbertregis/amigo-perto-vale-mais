using Entidades.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Basicas
{
    public class Usuario
    {
        public long UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? TipoUsuario { get; set; }
        public virtual List<Candidato> Candidatos { get; set; }
        public TipoUsuario? TipoUsuarioEnum
        {
            get { return (TipoUsuario?)TipoUsuario; }
            set { TipoUsuario = (int?)value; }
        }
    }
}
