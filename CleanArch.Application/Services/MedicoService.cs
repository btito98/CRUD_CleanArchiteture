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
    public class MedicoService : IMedicoService
    {
        private IMedicoRepository _medicoRepository;
        private readonly IMapper _mapper;

        public MedicoService(IMapper mapper, IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
            _mapper = mapper;
        }

        public async Task Add(MedicoViewModel medicoVM)
        {
            var medicoEntity = _mapper.Map<Medico>(medicoVM);
            await _medicoRepository.AddAsync(medicoEntity);

        }
        public async Task<MedicoViewModel> GetById(int? id)
        {
            var medicoEntity = await _medicoRepository.GetByIdAsync(id);
            return _mapper.Map<MedicoViewModel>(medicoEntity);
        }

        public async Task<IEnumerable<MedicoViewModel>> GetMedicos()
        {
            var medicoEntity = await _medicoRepository.GetMedicosAsync();
            return _mapper.Map<IEnumerable<MedicoViewModel>>(medicoEntity);
        }

        public async Task Remove(int id)
        {
            var medicoEntity = _medicoRepository.GetByIdAsync(id).Result;
            await _medicoRepository.RemoveAsync(medicoEntity);
        }

        public async Task Update(MedicoViewModel medicoVM)
        {
            var medicoEntity = _mapper.Map<Medico>(medicoVM);
            await _medicoRepository.UpdateAsync(medicoEntity);
        }
    }
}
