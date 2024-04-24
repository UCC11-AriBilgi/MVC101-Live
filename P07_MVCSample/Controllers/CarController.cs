using Microsoft.AspNetCore.Mvc;
using P07_MVCSample.Data;

namespace P07_MVCSample.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            // Listeleme yapacak

            return View(CarData.Cars); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }

        public IActionResult Create()
        {
            // Yeni bir veri gireceğim Create View a gidecek

            return View(); // 
        }

        public IActionResult Details()
        {
            // Listeleme yapacak

            return View(); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }

        public IActionResult Edit()
        {
            // Listeleme yapacak

            return View(); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }

        public IActionResult Delete()
        {
            // Listeleme yapacak

            return View(); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }
    }
}
