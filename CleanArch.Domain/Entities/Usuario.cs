using Clinica.Domain.Enum;
using Clinica.Domain.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Entities
{
    public class Usuario
    {        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public PerfilEnum? Perfil { get; set; }
        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }
        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }
    }
}
