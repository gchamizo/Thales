using Microsoft.AspNetCore.Mvc;

namespace Beca.Thales.Controllers
{
    
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
