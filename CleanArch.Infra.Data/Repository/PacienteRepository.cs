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
    public class PacienteRepository : Repository<Paciente>, IPacienteRepository
    {
        private ApplicationDbContext _pacienteContext;
        public PacienteRepository(ApplicationDbContext context) : base(context)
        {
            _pacienteContext = context;
        }

        public async Task<Paciente> AddAsync(Paciente paciente)
        {
            _pacienteContext.Add(paciente);
            await _pacienteContext.SaveChangesAsync();
            return paciente;
        }

        public async Task<Paciente> GetByIdAsync(int? id)
        {
            return await  _pacienteContext.Paciente.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Paciente>> GetPacientesAsync()
        {
            return await _pacienteContext.Paciente.ToListAsync();
        }

        public async Task<Paciente> RemoveAsync(Paciente paciente)
        {
            _pacienteContext.Paciente.Remove(paciente);
            await _pacienteContext.SaveChangesAsync();
            return paciente;
        }

        public async Task<Paciente> UpdateAsync(Paciente paciente)
        {
           _pacienteContext.Paciente.Update(paciente);
            await _pacienteContext.SaveChangesAsync();
            return paciente;
        }
    }
}
