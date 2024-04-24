using Microsoft.AspNetCore.Mvc;
using P05_PassingDataToViews.Models;

namespace P05_PassingDataToViews.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            // Yazar bilgilerini bir liste yapısı halinde oluşturma...

            List<Authors> authorlist=new List<Authors>();

            authorlist.Add(new Authors() { AuthorID = 1, AuthorName="Stephen King", BookName="It" });
            authorlist.Add(new Authors() { AuthorID = 2, AuthorName="Aleander Dumas", BookName="Three Musketeers" });
            authorlist.Add(new Authors() { AuthorID = 3, AuthorName="Seth Godin", BookName="Mor İnek" });
            authorlist.Add(new Authors() { AuthorID = 4, AuthorName="Seymen Bozaslan", BookName="İçinden Yol Geçen Hayatlar" });

            ViewBag.Message = "Bu ViewData ile tasınmış bir veridir";

            ViewData["Authors"] = authorlist;

            return View();
        }
    }
}
