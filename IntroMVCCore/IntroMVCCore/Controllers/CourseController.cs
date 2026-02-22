using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVCCore.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            Random rnd = new Random();
            var data = new List<Course>();
            for(int i = 1; i <= 10; i++)
            {
                data.Add(new Course()
                {
                    Id =i,
                    Title = "Course"+i.ToString(),
                    Credit = rnd.Next(1, 5),
                    Semester = rnd.Next(3,13)
                });
            }
            return View(data);
        }
    }
}
