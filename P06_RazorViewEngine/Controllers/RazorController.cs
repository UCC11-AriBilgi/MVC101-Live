using Microsoft.AspNetCore.Mvc;

namespace P06_RazorViewEngine.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
