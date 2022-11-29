using Beca.Thales.Models.Repositories;
using Beca.Thales.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Beca.Thales.Controllers
{
    public class HomeController : Controller
    {
        private readonly IActividadRepository _actividadRepository;

        public HomeController(IActividadRepository actividadRepository)
        {
            _actividadRepository = actividadRepository;
        }

        public ViewResult Index()
        {
            var maspopular = _actividadRepository.ActividadesMasPopulares;

            var homeViewModel = new HomeViewModel(maspopular);

            return View(homeViewModel);
        }
    }
}

