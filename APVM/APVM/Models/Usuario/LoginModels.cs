using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Entidades.Basicas;

namespace APVM.Models.Usuario
{
    public class LoginModels
    {
        
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public Entidades.Basicas.Usuario Usuario
        {
            get
            {
                return new Entidades.Basicas.Usuario() { Email = Login, Senha = Password };
            }

        }
    }

    
}