using DepartmentCrud.Data;
using DepartmentCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentCrud.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var departments = context.Departments.ToList();
            return View("Index",departments);
        }
        public IActionResult Details(int id)
        {
            var department = context.Departments.First(department =>department.Id == id );
            return View("Details",department);
        }
        public IActionResult Create() 
        {
            return View("Create");
        }

        public IActionResult Store(Department department)
        {
           context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");   
        }

        public IActionResult Delete(int id)
        {
            var department = context.Departments.Find(id);
            context.Departments.Remove(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
