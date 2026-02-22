using IntroMVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVCCore.Controllers
{
    public class StudentTask1Controller : Controller
    {
        public IActionResult Index()
        {
            StudentTask1 stu1 = new StudentTask1()
            {
                Id = 1,
                Name = "John Doe",
                Age = 20,
                Department = "Computer Science",
                Cgpa = 3.2f
            };
            StudentTask1 stu2 = new StudentTask1()
            {
                Id = 2,
                Name = "John Doe",
                Age = 19,
                Department = "EEE",
                Cgpa = 3.5f
            };
            StudentTask1 stu3 = new StudentTask1()
            {
                Id = 3,
                Name = "John Doe",
                Age = 21,
                Department = "Computer Science",
                Cgpa = 3.8f
            };
            StudentTask1[] students = new StudentTask1[] { stu1, stu2, stu3 };
            return View(students);
        }

        
    }
}
