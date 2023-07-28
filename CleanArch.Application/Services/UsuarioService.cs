using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.ViewModels;
using Clinica.Domain.Entities;
using Clinica.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IMapper mapper, IUsuarioRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }
        public async Task Add(UsuarioViewModel usuarioVM)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioVM);
            await _usuarioRepository.AddAsync(usuarioEntity);
        }

        public Usuario BuscarLogin(string login)
        {
            var usuarioEntity = _mapper.Map<Usuario>(login);
            return _usuarioRepository.BuscarLogin(login);
        }

        public async Task<UsuarioViewModel> GetById(int? id)
        {
            var usuarioEntity = await _usuarioRepository.GetByIdAsync(id);
            return _mapper.Map<UsuarioViewModel>(usuarioEntity);
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetUsuarios()
        {
            var usuarioEntity = await _usuarioRepository.GetUsuariosAsync();
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(usuarioEntity);
        }

        public async Task Remove(int id)
        {
            var usuarioEntity = _usuarioRepository.GetByIdAsync(id).Result;
            await _usuarioRepository.RemoveAsync(usuarioEntity);
        }

        public async Task Update(UsuarioViewModel usuarioVM)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioVM);
            await _usuarioRepository.UpdateAsync(usuarioEntity);
        }
    }
}
