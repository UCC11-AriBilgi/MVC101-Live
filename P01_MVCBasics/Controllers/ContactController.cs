using Microsoft.AspNetCore.Mvc;

namespace P01_MVCBasics.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
