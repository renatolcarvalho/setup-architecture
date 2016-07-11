using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SetupWebApplication.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(100, ErrorMessage = null)]
        [MinLength(2, ErrorMessage = null)]
        [DisplayName("Nome do Usuário")]
        public string Nome { get; set; }
    }
}