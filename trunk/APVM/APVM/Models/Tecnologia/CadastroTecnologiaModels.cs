using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APVM.Models.Tecnologia
{
    public class CadastroTecnologiaModels
    {

        [Display(Name = "Tecnologia")]
        [Required(ErrorMessage = "Informe a Tecnologia")]
        public string NomeTecnologia { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe a Descrição")]
        public string Descricao { get; set; }

        public Entidades.Basicas.Tecnologia Tecnologia
        {
            get
            {
                return new Entidades.Basicas.Tecnologia() { Nome = NomeTecnologia, Descricao = Descricao};
            }

        }
    }
}