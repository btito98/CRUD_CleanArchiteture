using Clinica.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IMedicoService
    {
        Task<IEnumerable<MedicoViewModel>> GetMedicos();
        Task<MedicoViewModel> GetById(int? id);
        Task Add(MedicoViewModel medicoVM);
        Task Update(MedicoViewModel medicoVM);
        Task Remove(int id);
    }
}
