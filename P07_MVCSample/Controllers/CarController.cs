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

        public IActionResult Details(int id)
        {
            // Index view üzerinde basıldığında ilgili kaydın detay bilgilerini bir form yapısı şeklinde gösterecek
            var car= CarData.Cars.Where(c=> c.CarId==id).FirstOrDefault(); // gelen id parametresine göre ilgili id yi listede ara bulduğunda view a gönder.

            return View(car); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }

        //GET
        public IActionResult Edit(int id)
        {
            // View(Index,Details) tarafından gönderilen id bilgisine göre ilgili kayıt değişiklik yapılabilecek şekilde Edit view a gönderecek
            var car = CarData.Cars.Where(c => c.CarId == id).FirstOrDefault();

            return View(car); // CarData içersindeki varolan bilgiyi Edit View üzerine gönder
        }

        //POST
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            // Edit view tarafından gönderilecek olan Datalar ilgili kayıt bulunarak güncellenecek

            Car editcar=CarData.Cars.Where(c=> c.CarId==car.CarId).FirstOrDefault(); // Kayıdı buluyor

            // Yeni gelen bilgilerin listem üzerinde güncellenmesi

            editcar.BrandName=car.BrandName;
            editcar.Family=car.Family;
            editcar.Year=car.Year;

            return RedirectToAction("Index"); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }

        // GET
        public IActionResult Delete(int id)
        {
            // Burası View tarafında gösterilen id bilgisine göre ilgili kaydı silme onayı almak için Delete view a gönderecek.

            var car=CarData.Cars.Where(c=> c.CarId==id).FirstOrDefault();

            return View(car); // CarData içersindeki varolan bilgiyi Delete View üzerine gönder
        }

        [HttpPost]
        public IActionResult Delete(Car car)
        {
            // Delete View tarafından gönderilecek id bilgisine göre ilgili kaydı öğrenerek post ile bu metoda gelecek

            Car deletecar = CarData.Cars.Where(c => c.CarId == car.CarId).FirstOrDefault(); // silinecek kayıdı buldu

            CarData.Cars.Remove(deletecar);

            return RedirectToAction("Index"); // CarData içersindeki varolan bilgiyi Index View üzerine gönder
        }
    }
}
