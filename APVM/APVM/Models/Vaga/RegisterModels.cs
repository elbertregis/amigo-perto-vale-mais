using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Entidades.Util;
using Negocios.Negocios;

namespace APVM.Models.Vaga
{
    public class RegisterModels
    {

        [Display(Name = "Descrição da Vaga")]
        [Required(ErrorMessage = "Informe a Descrição da Vaga.")]
        public string DescricaoVaga { get; set; }

        [Display(Name = "Resumo")]
        [Required(ErrorMessage = "Informe o Resumo.")]
        public string Descricao { get; set; }

        [Display(Name = "Validade")]
        [Required(ErrorMessage = "Informe a Validade.")]
        public DateTime Validade { get; set; }

        [Display(Name = "Nivel")]
        [Required(ErrorMessage = "Informe o Nivel.")]
        private int Nivel { get; set; }

        public bool Checked { get; set; }
        
        public List<Entidades.Basicas.Tecnologia> ListaTecnologia { get; set; }

        public RegisterModels()
        {
            TecnologiaNegocios tecnologiaNegocios = new TecnologiaNegocios();
            this.ListaTecnologia = new List<Entidades.Basicas.Tecnologia>();
            this.ListaTecnologia = tecnologiaNegocios.ObterTodos();
        }

    }
}