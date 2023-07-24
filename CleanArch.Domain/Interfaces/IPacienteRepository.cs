using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetPacientesAsync();
        Task<Paciente> GetByIdAsync(int? id);
        Task<Paciente> AddAsync (Paciente paciente);
        Task<Paciente> UpdateAsync (Paciente paciente);
        Task<Paciente> RemoveAsync (Paciente paciente);
    }
}
