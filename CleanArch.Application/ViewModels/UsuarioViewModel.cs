using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace Clinica.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        [DisplayName("Nome")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [MaxLength(30, ErrorMessage = "O email deve ter no máximo 80 caracteres.")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "O login é obrigatório")]
        [MinLength(5, ErrorMessage = "O login deve ter no mínimo 5 caracteres.")]
        [MaxLength(15, ErrorMessage = "O login deve ter no máximo 15 caracteres.")]
        public string Login { get; set; }

        [Required(ErrorMessage ="A senha é obrigatória ]")]
        [MinLength(8, ErrorMessage ="A senha deve ter no mínimo 8 caracteres.")]
        [MaxLength(15, ErrorMessage = "A senha deve ter no máximo 15 caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
