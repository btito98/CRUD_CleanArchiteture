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
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        private ApplicationDbContext _medicoContext;
        public MedicoRepository(ApplicationDbContext context) : base(context)
        {
            _medicoContext = context;
        }

        public async Task<Medico> AddAsync(Medico medico)
        {
            _medicoContext.Add(medico);
            await _medicoContext.SaveChangesAsync();
            return medico;
        }

        public async Task<Medico> GetByIdAsync(int? id)
        {
            return await _medicoContext.Medico.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Medico>> GetMedicosAsync()
        {
            return await _medicoContext.Medico.ToListAsync();
        }

        public async Task<Medico> RemoveAsync(Medico medico)
        {
            _medicoContext.Medico.Remove(medico);
            await _medicoContext.SaveChangesAsync();
            return medico;

        }

        public async Task<Medico> UpdateAsync(Medico medico)
        {
            _medicoContext.Update(medico);
            await _medicoContext.SaveChangesAsync();
            return medico;
        }


    }
}
