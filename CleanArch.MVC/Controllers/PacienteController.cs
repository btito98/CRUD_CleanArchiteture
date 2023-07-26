using Clinica.Application.Interfaces;
using Clinica.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.MVC.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _pacienteService.GetPacientes();
            return View(result);
        }
    }
}
