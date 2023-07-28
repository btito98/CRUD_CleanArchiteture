using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{    
      public interface ISessao
      {        
          void CriarSessaoUsuario(Usuario usuario);
          Usuario BuscarSessaoUsuario();
          void RemoverSessaoUsuario();
      }    
}
