using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVCCore.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products;
        public ProductController() {

            Random rnd = new Random();
            var data = new List<Product>();
            for (int i = 1; i <= 10; i++)
            {
                data.Add(new Product()
                {
                    Id = i,
                    Name = "Product " + i.ToString(),
                    Price = rnd.Next(100, 1000),
                    Description = "This is product " + i.ToString()
                });
            }
            products = data;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            
            return View(products);
        }
        public IActionResult Details(int id)
        {
            //var data=new Product()
            //{
            //    Id = id,
            //    Name = "Product " + id,
            //    Price = 500,
            //    Description = "This is product " + id
            //};
            var data=products.Find(p => p.Id == id);
            
            return View(data);
        }
    }
}
