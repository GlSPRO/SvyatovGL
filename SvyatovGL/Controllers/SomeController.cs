using Microsoft.AspNetCore.Mvc;

namespace SvyatovGL.Controllers
{
    public class SomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
