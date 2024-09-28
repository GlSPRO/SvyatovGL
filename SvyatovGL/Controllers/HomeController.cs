using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SvyatovGL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string theme = Request.Cookies["Theme"] ?? "light";
            ViewBag.Theme = theme;
            return View();
        }

        [HttpPost]
        public IActionResult ChangeTheme(string theme)
        {
            Response.Cookies.Append("Theme", theme, new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return RedirectToAction("Index");
        }
    }
}
