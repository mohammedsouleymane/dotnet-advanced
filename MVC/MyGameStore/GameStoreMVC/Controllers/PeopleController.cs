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
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult GetById(int id)
        {
            return View(_service.GetbyId(id));
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Person person)
        {
            _service.Add(person);
            return RedirectToAction("GetById",person);
        }

        public IActionResult Update(int id)
        {
            return View(_service.GetAll().First(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {

            _service.Update(person);
            return RedirectToAction("GetById",person);
        }
    }
}
