using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using MyGameStore.DAL;
using MyGameStore.DAL.DAL;
using MyGameStore.BLL.Services;
using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL.Repositories;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StoreController : ControllerBase
    {
        private IStore _service;

        public StoreController(IStore context)
        {
            _service = context;
        }

        [HttpPost]

        public IActionResult Post([FromBody] Store store)
        {
            _service.Add(store);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetbyId(id));
        }
        [HttpGet]
        public IActionResult Get(Sort sort, SortBy sortBy, string city, string zipCode, int page=1, int pageLength=10)
        {         
            var result = _service.GetAll(sort, sortBy, city,zipCode,page,pageLength);
            if (!result.Any())
                return NotFound();
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Store store)
        {
            _service.Update(store);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
