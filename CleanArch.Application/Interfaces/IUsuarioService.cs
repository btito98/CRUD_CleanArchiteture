using Clinica.Application.ViewModels;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioViewModel>> GetUsuarios();
        Task<UsuarioViewModel> GetById(int? id);
        Task Add(UsuarioViewModel usuarioVM);
        Task Update(UsuarioViewModel usuarioVM);
        Task Remove(int id);
        Usuario BuscarLogin(string login);
    }
}
