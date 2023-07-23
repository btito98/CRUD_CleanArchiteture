using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.ViewModels
{
    public class MedicoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(4)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CRM é obrigatório")]
        [DisplayName("CRM")]
        public int CRM { get; set; }

        [Required(ErrorMessage = "A especialidade é obrigatória")]
        [MinLength(6)]
        [MaxLength(30)]
        [DisplayName("Especialidade")]
        public string Especialidade { get; set; }

        
    }
}
