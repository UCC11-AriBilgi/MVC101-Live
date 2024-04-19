using Microsoft.AspNetCore.Mvc;
using P01_MVCBasics.Models;
using System.Diagnostics;

namespace P01_MVCBasics.Controllers
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
            return View(); // Index isimli (Index.cshtml) view a git ..goster
        }

        public IActionResult Index2() // Sadece Index2 isimli metotoda git...
        {
            return Content("Burası view ı olmayan bir metotdur....");
        }

        public IActionResult Privacy() //Privacy isimli(Privacy.cshtml) view a git..goster
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
