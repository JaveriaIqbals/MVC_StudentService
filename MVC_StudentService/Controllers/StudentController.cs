using Microsoft.AspNetCore.Mvc;
using MVC_StudentService.Services;

namespace MVC_StudentService.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _iss;
        public StudentController(IStudentService iss)
        {
            _iss = iss;
        }
        public IActionResult Index()
        {
            return View(_iss.GetAllStudents());
        }

        // A single method will be used here for Get and Post 
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _iss.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
