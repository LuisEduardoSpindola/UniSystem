using Microsoft.AspNetCore.Mvc;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Controllers
{
    public class ExerciseController : Controller
    {
        private IRepositoryExercise _ExerciseServices { get; set; }

        public ExerciseController(IRepositoryExercise ExerciseServices)
        {
            _ExerciseServices = ExerciseServices;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Exercise exercise)
        {
            _ExerciseServices.Create(exercise);
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll(Exercise exercise)
        {
            var result = _ExerciseServices.GetAll(exercise);
            return View(result);
        }

        public IActionResult GetById(int id)
        {
            var result = _ExerciseServices.GetById(id);
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var result = _ExerciseServices.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Exercise exercise)
        {
            _ExerciseServices.Create(exercise);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            var result = _ExerciseServices.GetById(id);
            return View(result);
        }

        [HttpDelete]
        public IActionResult DeleteConfirm(int id)
        {
            _ExerciseServices.Delete(id);
            return RedirectToAction("GetAll");
        }


        public IActionResult Details(int id)
        {
            Exercise result = _ExerciseServices.GetById(id);
            return View(result);
        }
    }
}
