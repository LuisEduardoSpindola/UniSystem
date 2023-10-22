using Microsoft.AspNetCore.Mvc;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Controllers
{
    public class CourseController : Controller
    {
        private IRepositoryCourse _CourseServices { get; set; }

        public CourseController(IRepositoryCourse CourseServices)
        {
            _CourseServices = CourseServices;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course) 
        {
            _CourseServices.Create(course);
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll(Course course) 
        {
            var result = _CourseServices.GetAll(course);
            return View(result);
        }

        public IActionResult GetById(int id) 
        {
            var result = _CourseServices.GetById(id);
            return View(result);
        }

        public IActionResult Edit(int id) 
        {
            var result = _CourseServices.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Course course) 
        {
            _CourseServices.Create(course);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id) 
        {
            var result = _CourseServices.GetById(id);
            return View(result);
        }

        [HttpDelete]
        public IActionResult DeleteConfirm(int id) 
        {
            _CourseServices.Delete(id);
            return RedirectToAction("GetAll");
        }

        
        public IActionResult Details(int id)
        {
            Course result = _CourseServices.GetById(id);
            return View(result);
        }
    }
}
