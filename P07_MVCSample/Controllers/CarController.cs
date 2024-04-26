using Microsoft.AspNetCore.Mvc;
using P07_MVCSample.Data;
using P07_MVCSample.Models;

namespace P07_MVCSample.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            // Listeleme yapacak

            return View(CarData.Cars); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }

        // GET
        [HttpGet]
        public IActionResult Create()
        {
            // Yeni bir veri girebileceğim Create View a gidecek

            return View(); // 
        }

        // POST
        // View tarafından submit edildiğinde gelinecek/dönülecek olan Action
        [HttpPost]
        public IActionResult Create(Car newcar)
        {
            // Create View dan gelecek olan ilgili modelin verilerini listeme ekleyeceğim.

            CarData.Cars.Add(newcar);

            return RedirectToAction("Index"); // İşlem gerçekleştikten sonra direkt olarak yine Index View a gönderiyorum.
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
