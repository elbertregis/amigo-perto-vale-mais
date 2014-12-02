using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Design;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entidades.Basicas;

namespace Dados
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("name=AmigoPertoValeMais")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vaga> Vagas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public static Contexto CriarContexto()
        {
            return new Contexto();
        }
    }
}
