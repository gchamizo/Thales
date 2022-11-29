using Beca.Thales.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Beca.Thales.Controllers
{
    public class ContactController : Controller
    {

        [HttpGet("Contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

