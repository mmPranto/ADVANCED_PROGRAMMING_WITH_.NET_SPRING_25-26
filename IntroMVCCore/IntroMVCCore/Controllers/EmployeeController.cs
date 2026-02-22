using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVCCore.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employee()
        {
            string[] jobs = { "Manager", "Sellsman", "Cleaner"};
            Random rnd = new Random();

            var data = new List<Employee>();
            for(int i = 1; i <= 10; i++)
            {
                data.Add(new Employee()
                {
                    Name = "Employee" + i.ToString(),
                    Salary = rnd.Next(40000, 80000),
                    Designation = jobs[rnd.Next(jobs.Length)]

                });
            }

            return View(data);
        }

    }
}
