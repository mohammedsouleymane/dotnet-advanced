using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGameStore.DAL;
using OfficeOpenXml;
using System.IO;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private GameContext _context;

        public PersonController(GameContext context)
        {
            _context = context;
        }

        [HttpPost]

        public IActionResult Post([FromBody] Person person)
        {
            _context.tblPeople.Add(person);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.tblPeople;
            if (result.Any() == false)
                return NotFound();


            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.tblPeople.FirstOrDefault(ed => ed.Id == id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }


        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            _context.Update(person);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Person person = new() {Id = id};
            _context.Remove(person);
            _context.SaveChanges();
            return Ok();
        }
    }
}
