using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoServico.Models
{
    public class ContatoModel
    {
        public int IdContato { get; set; }

        [MinLength(3,ErrorMessage ="Informe no mínimo {1} caractes.")]
        [MaxLength(50,ErrorMessage ="Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage ="Por favor, informe o nome.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage ="Informe um endereço de e-mail válido.")]
        [Required(ErrorMessage ="Por favor, informe o e-mail.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Informe um número de telefone válido.")]
        [Required(ErrorMessage = "Por favor, informe o telefone do contato.")]
        public string Telefone { get; set; }
    }
}