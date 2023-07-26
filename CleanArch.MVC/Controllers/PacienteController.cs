using Clinica.Application.Interfaces;
using Clinica.Application.Services;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
			if (id == null) return NotFound();

			var pacienteVM = await _pacienteService.GetById(id);

			if (pacienteVM == null) return NotFound();

			return View(pacienteVM);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit([Bind("Id,Nome,DataNascimento,Telefone,Email")] PacienteViewModel pacienteVM)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_pacienteService.Update(pacienteVM);
				}
				catch (Exception ex)
				{
					throw;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(pacienteVM);
		}

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var pacienteVM = await _pacienteService.GetById(id);

            if (pacienteVM == null) return NotFound();

            return View(pacienteVM);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacienteVM = await _pacienteService.GetById(id);

            if (pacienteVM == null)
            {
                return NotFound();
            }

            return View(pacienteVM);
        }

        [HttpPost(), ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _pacienteService.Remove(id);


            return RedirectToAction("Index");
        }
    }
}
