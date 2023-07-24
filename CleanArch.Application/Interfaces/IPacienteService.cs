using Clinica.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteViewModel>> GetPacientes();
        Task<PacienteViewModel> GetById(int? id);
        Task Add(PacienteViewModel pacienteVM);
        Task Update(PacienteViewModel pacienteVM);
        Task Remove(int id);
    }
}
