using Microsoft.AspNetCore.Mvc;
using MyGameStore.BLL.Interfaces;
using MyGameStore.BLL.Services;
using MyGameStore.DAL;
using MyGameStore.DAL.DAL;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPerson _service;

        public PersonController(IPerson context)
        {
            _service = context;
        }

        [HttpPost]

        public IActionResult Post([FromBody] Person person)
        {
            person.Id = 0;
            _service.Add(person);           
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetbyId(id));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            _service.Update(person);
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
