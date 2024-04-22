using Microsoft.AspNetCore.Mvc;
using P05_PassingDataToViews.Models;

namespace P05_PassingDataToViews.Controllers
{
    public class CarController : Controller
    {
        // ViewBag
        // Daha küçük boyutlardaki verileri taşımak için kullanılabilir.
        // Tek yönlüdür Controller > View a (Tersi mümkün değil)
        // Viewbag herhangi bir sayfa tazaleme durumunda içeriği temizlenir
        // Eğer birden fazla aynı viewbag tanımlaması varsa en son durumdaki geçerlidir.

        // ViewData
        // Esas farkı background da veriyi tutmasıdır.


        public IActionResult Index()
        {
            List<Cars>carlist = new List<Cars>();

            carlist.Add(new Cars() { CarId = 1, BrandName = "Volvo", Family = "XC70", Year = 1995 });
            carlist.Add(new Cars() { CarId = 2, BrandName = "Volkswagen", Family = "Beetle 1303", Year = 1974 });
            carlist.Add(new Cars() { CarId = 3, BrandName = "Bugatti", Family = "Chiron", Year = 2015 });
            carlist.Add(new Cars() { CarId = 4, BrandName = "Ferrari", Family = "California", Year = 2022 });
            carlist.Add(new Cars() { CarId = 5, BrandName = "Dodge", Family = "Charger SRT 8", Year = 1970 });

            ViewBag.Message = "Bu bilgi Viewbag ile taşınan bir veridir";


            return View(carlist);
        }
    }
}
