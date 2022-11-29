using Beca.Thales.Models.Repositories;
using Beca.Thales.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Beca.Thales.Controllers
{
    [Route("api/[Controller]")]
    public class ActividadController : Controller
    {
        private readonly IActividadRepository _actividadRepository;
        private readonly IAreaRepository _areaRepository;

        public ActividadController(IActividadRepository actividadRepository, IAreaRepository areaRepository)
        {
            _actividadRepository = actividadRepository;
            _areaRepository = areaRepository;
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            ActividadListViewModel actividadListViewModel = new ActividadListViewModel(_actividadRepository.AllActividades, "Actividades");
            return View(actividadListViewModel);
        }

        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var actividad = _actividadRepository.GetActividadById(id);
            if (actividad == null)
                return NotFound();

            return View(actividad);
        }

    }

}

