using Clinica.Application.Interfaces;
using Clinica.Application.Services;
using Clinica.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.MVC.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicoService _mediicoService;

        public MedicoController(IMedicoService medicoService)
        {
            _mediicoService = medicoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _mediicoService.GetMedicos();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,CRM,Especialidade")] MedicoViewModel medicoVM)
        {
            if (ModelState.IsValid)
            {
                _mediicoService.Add(medicoVM);
                return RedirectToAction(nameof(Index));
            }
            return View(medicoVM);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var medicoVM = await _mediicoService.GetById(id);

            if (medicoVM == null) return NotFound();

            return View(medicoVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id,Nome,CRM,Especialidade")] MedicoViewModel medicoVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _mediicoService.Update(medicoVM);
                }
                catch (Exception ex)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicoVM);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null) return NotFound();

            var medicoVM = await _mediicoService.GetById(id);

            if(medicoVM == null) return NotFound();

            return View(medicoVM);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicoVM = await _mediicoService.GetById(id);

            if (medicoVM == null)
            {
                return NotFound();
            }

            return View(medicoVM);
        }

        [HttpPost(), ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _mediicoService.Remove(id);


            return RedirectToAction("Index");
        }


    }
}
