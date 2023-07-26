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
    public class PacienteService : IPacienteService
    {
        private IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;
        public PacienteService(IMapper mapper, IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }
        public async Task Add(PacienteViewModel pacienteVM)
        {
            var pacienteEntity = _mapper.Map<Paciente>(pacienteVM);
            await _pacienteRepository.AddAsync(pacienteEntity);
        }

        public async Task<PacienteViewModel> GetById(int? id)
        {
            var pacienteEntity = await _pacienteRepository.GetByIdAsync(id);
            return _mapper.Map<PacienteViewModel>(pacienteEntity);
        }

        public async Task<IEnumerable<PacienteViewModel>> GetPacientes()
        {
           var pacienteEntity = await _pacienteRepository.GetPacientesAsync();
            return _mapper.Map<IEnumerable<PacienteViewModel>>(pacienteEntity);
        }

        public async Task Remove(int id)
        {
            var pacienteEntity = _pacienteRepository.GetByIdAsync(id).Result;
            await _pacienteRepository.RemoveAsync(pacienteEntity);

        }

        public async Task Update(PacienteViewModel pacienteVM)
        {
            var pacienteEntity = _mapper.Map<Paciente>(pacienteVM);
            await _pacienteRepository.UpdateAsync(pacienteEntity);
        }
    }
}
