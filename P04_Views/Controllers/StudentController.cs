using Microsoft.AspNetCore.Mvc;
using P04_Views.Models;

namespace P04_Views.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "ÜmitK",
                EMail = "uk@gmail.com",
                Phone = "01112223344",
                Gender = "E"
            };

            ViewData["StudentInfo"]=student;

            return View(ViewData["StudentInfo"]); // View a giderken datayı da yanında götür.
        }
    }
}
