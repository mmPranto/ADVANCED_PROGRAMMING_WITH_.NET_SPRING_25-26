using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace IntroMVCCore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            String[] categories = { "Programming", "Database", "Web Development", "Mobile Development" };
            Random rnd = new Random();
            var data = new List<Book>();

            for (int i = 1; i <= 10; i++)
            {
                data.Add(new Book()
                {
                    Id = i,
                    Title = "Title" + i.ToString(),
                    Author = "Author" + i.ToString(),
                    Category = categories[rnd.Next(categories.Length)]
                });
            }
            return View(data);
        }
    }
}
