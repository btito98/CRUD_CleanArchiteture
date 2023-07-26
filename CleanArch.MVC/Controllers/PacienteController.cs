using Clinica.Application.Interfaces;
using Clinica.Application.ViewModels;
using Clinica.Domain.Entities;
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
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([Bind("Id,Nome,DataNascimento,Telefone,Email")] PacienteViewModel pacienteVM)
        {
            if (ModelState.IsValid)
            {
                _pacienteService.Add(pacienteVM);
				return RedirectToAction(nameof(Index));
			}
			return View(pacienteVM);
		}
    }
}
