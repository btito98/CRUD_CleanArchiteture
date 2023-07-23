using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Interfaces
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> GetMedicosAsync();
        Task<Medico> GetByIdAsync(int? id);
        Task<Medico> AddAsync(Medico medico);
        Task<Medico> UpdateAsync(Medico medico);
        Task<Medico> RemoveAsync(Medico medico);
    }
}
