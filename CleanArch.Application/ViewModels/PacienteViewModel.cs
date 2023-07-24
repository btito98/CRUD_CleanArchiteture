using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.ViewModels
{
    public class PacienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(4)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Data de nascimento é obrigatória")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento{ get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [MinLength(11)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [MaxLength(80)]
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
