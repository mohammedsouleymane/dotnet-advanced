using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL;

namespace GameStoreMVC.Controllers
{
    public class PeopleController : Controller
    {
        private IPerson _service;

        public PeopleController(IPerson context)
        {
            _service = context;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult GetById(int id)
        {
            Person person = _service.GetbyId(id);
            if (person == null)
                return NotFound("Person not found");
            return View(person);
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Person person)
        {
            try
            {
                _service.Add(person);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
            
            return RedirectToAction("GetById",person);
        }

        public IActionResult Update(int id)
        {
            Person person = _service.GetbyId(id);
            if(person == null)
                return NotFound("Person not found");
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {

            _service.Update(person);
            return RedirectToAction("GetById",person);
        }
    }
}
