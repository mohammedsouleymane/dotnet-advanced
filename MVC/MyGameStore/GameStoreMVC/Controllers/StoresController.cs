using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL;
using MyGameStore.DAL.Repositories;

namespace GameStoreMVC.Controllers
{
    public class StoresController : Controller
    {
        private IStore _service;

        public StoresController(IStore context)
        {
            _service = context;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll(Sort.Ascending, SortBy.Name,"","",1,100).OrderBy(x => x.Id));
        }

        public IActionResult GetById(int id)
        {
            return View(_service.GetbyId(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View(_service.GetAll(Sort.Ascending, SortBy.Name, "", "", 1, 100).First(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult Update(Store store)
        {

            _service.Update(store);
            return RedirectToAction("GetById", store);
        }
        [HttpPost]
        public IActionResult Create(Store store)
        {
            _service.Add(store);
            return RedirectToAction("GetById", store);
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}


