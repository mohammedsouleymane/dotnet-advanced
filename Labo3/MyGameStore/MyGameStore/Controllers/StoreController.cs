using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGameStore.DAL;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private GameContext _context;

        public StoreController(GameContext context)
        {
            _context = context;
        }

        [HttpPost]

        public IActionResult Post([FromBody] Store store)
        {
            _context.tblStores.Add(store);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.tblStores;
            if (result.Any() == false)
                return NotFound();


            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.tblStores.FirstOrDefault(ed => ed.Id == id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Store store)
        {
            _context.Update(store);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Store store = new() {Id = id};
            _context.Remove(store);
            _context.SaveChanges();
            return Ok();
        }
    }
}
