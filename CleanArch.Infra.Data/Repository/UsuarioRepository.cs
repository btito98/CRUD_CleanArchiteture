using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces;
using Clinica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Infra.Data.Repository
{
    public class UsuarioRepository :Repository<Usuario>, IUsuarioRepository
    {
        private ApplicationDbContext _usuarioContext;
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
            _usuarioContext = context;
        }
        public async Task<Usuario> AddAsync(Usuario usuario)
        {
            _usuarioContext.Add(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }

        public Usuario BuscarLogin(string login)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetByIdAsync(int? id)
        {
            return await _usuarioContext.Usuario.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            return await _usuarioContext.Usuario.ToListAsync();
        }

        public async Task<Usuario> RemoveAsync(Usuario usuario)
        {
            _usuarioContext.Remove(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> UpdateAsync(Usuario usuario)
        {
            _usuarioContext.Update(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }
    }
}
