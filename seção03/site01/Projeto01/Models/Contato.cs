using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve conter máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatorio")]
        [MaxLength(70, ErrorMessage = "O campo 'Email' deve conter máximo 70 caracteres")]
        [EmailAddress(ErrorMessage = "O campo 'Email' é Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Assunto' é obrigatorio")]
        [MaxLength(70, ErrorMessage = "O campo 'Assunto' deve conter máximo 70 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo 'Mensagem' é obrigatorio")]
        [MaxLength(2000, ErrorMessage = "O campo 'Mensagem' deve conter máximo 2000 caracteres")]
        public string Mensagem { get; set; }
    }
}
