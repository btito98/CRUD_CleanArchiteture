﻿using System;
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
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Data de nascimento é obrigatória")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento{ get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [MinLength(11,ErrorMessage = "O telefone deve ter no mínino 11 caracteres.")]
        [DisplayName("Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [MaxLength(30, ErrorMessage = "O email deve ter no máximo 80 caracteres.")]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
