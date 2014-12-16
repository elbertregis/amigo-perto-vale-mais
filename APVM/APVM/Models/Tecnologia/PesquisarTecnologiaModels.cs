using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Entidades;
using Negocios.Negocios;

namespace APVM.Models.Tecnologia
{
    public class PesquisarTecnologiaModels
    {

        [Display(Name = "Tecnologia")]
        [Required(ErrorMessage = "Informe a Tecnologia")]
        public string NomeTecnologia { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe a Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "ListaTecnologia")]
        public List<Entidades.Basicas.Tecnologia> ListaTecnologia { get; set; }

        public PesquisarTecnologiaModels()
        {
            TecnologiaNegocios tecnologiaNegocios = new TecnologiaNegocios();
            this.ListaTecnologia = new List<Entidades.Basicas.Tecnologia>();
            this.ListaTecnologia = tecnologiaNegocios.ObterTodos();
        }
    }
}