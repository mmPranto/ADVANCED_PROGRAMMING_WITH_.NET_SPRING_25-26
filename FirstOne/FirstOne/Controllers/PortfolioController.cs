using FirstOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstOne.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Tanvir";
            return View();
        }
        public IActionResult Education()
        {
           

            ViewBag.Name = "Tanvir";
            ViewBag.Id = "434343";


            ViewData["Name"] = "Ahmed";
            ViewData["Id"] = "123456";
            return View();
        }

        public IActionResult Education2()
        {
            EducationItem ed1 = new EducationItem();
            ed1.Title = "SSC";
            ed1.Result = 4.56f;
            ed1.Year = 2014;

            EducationItem ed2 = new EducationItem()
            {
                Title = "HSC",
                Result = 5.00f,
                Year = 2020,
            };
            EducationItem ed3 = new EducationItem()
            {
                Title = "HSC",
                Result = 5.00f,
                Year = 2020,
            };
            EducationItem ed4 = new EducationItem()
            {
                Title = "HSC",
                Result = 5.00f,
                Year = 2020,
            };

            EducationItem[] edus = new EducationItem[] { ed1, ed2, ed3, ed4 };


            return View(edus);//model binding
        }
    }
}
