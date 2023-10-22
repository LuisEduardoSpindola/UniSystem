using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using UniSys.Interfaces;
using UniSys.Models;
using UniSys.Repositories;

namespace UniSys.Controllers
{
    public class InformationController : Controller
    {
        private IRepositoryInformation _InformationServices { get; set; }

        public InformationController(IRepositoryInformation InformationServices)
        {
            _InformationServices = InformationServices;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Information information)
        {
            _InformationServices.Create(information);
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll(Models.Information information)
        {
            var result = _InformationServices.GetAll(information);
            return View(result);
        }

        public IActionResult GetById(int id)
        {
            var result = _InformationServices.GetById(id);
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var result = _InformationServices.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Models.Information information)
        {
            _InformationServices.Create(information);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            var result = _InformationServices.GetById(id);
            return View(result);
        }

        [HttpDelete]
        public IActionResult DeleteConfirm(int id)
        {
            _InformationServices.Delete(id);
            return RedirectToAction("GetAll");
        }


        public IActionResult Details(int id)
        {
            Models.Information result = _InformationServices.GetById(id);
            return View(result);
        }
    }
}
