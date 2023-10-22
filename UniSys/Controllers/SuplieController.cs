using Microsoft.AspNetCore.Mvc;
using System;
using UniSys.Interfaces;
using UniSys.Models;

namespace UniSys.Controllers
{
    public class SuplieController : Controller
    {
        private IRepositorySuplie _SuplieServices { get; set; }

        public SuplieController(IRepositorySuplie SuplieServices)
        {
            _SuplieServices = SuplieServices;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Suplie suplie)
        {
            _SuplieServices.Create(suplie);
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll(Suplie suplie)
        {
            var result = _SuplieServices.GetAll(suplie);
            return View(result);
        }

        public IActionResult GetById(int id)
        {
            var result = _SuplieServices.GetById(id);
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var result = _SuplieServices.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Suplie suplie)
        {
            _SuplieServices.Create(suplie);
            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int id)
        {
            var result = _SuplieServices.GetById(id);
            return View(result);
        }

        [HttpDelete]
        public IActionResult DeleteConfirm(int id)
        {
            _SuplieServices.Delete(id);
            return RedirectToAction("GetAll");
        }


        public IActionResult Details(int id)
        {
            Suplie result = _SuplieServices.GetById(id);
            return View(result);
        }
    }
}
