using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace MyGameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        static private List<Person> people = new List<Person>()
            {new Person(1, "Souleymane", "Mohammed", 1,"sdf",1), new Person(2, "Saadi", "Mohammed", 1,"sfd",1)};

        private int FindPersonById(int id)
        {
            int personToReturn = -1;
            for (int i = 0; i < people.Count; i++)
            {
                if (id == people[i].Id)
                    personToReturn = i;
            }

            return personToReturn;
        }

     

        [HttpGet]
        public IActionResult GetAll()
        {
            if (Request.Query.ContainsKey("Lastname"))
            {
                string lastName = Request.Query["Lastname"];
                List<Person> peopleByLastName = new List<Person>();
                foreach (var person in people)
                {
                    if(lastName == person.LastName)
                        peopleByLastName.Add(person);
                }
                return Ok(peopleByLastName);
            }
            return Ok(people);
        }

        [Route("{Person}")]
        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            people.Add(person);
            var result = Content("201");
            result.StatusCode = 201;
            return result;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetPersonById(int id)
        {
            return Ok(people[FindPersonById(id)]);
        }


        [Route("{id}")]
        [HttpPut]
        public IActionResult UpdatePersonById(int id, [FromBody] Person person)
        {
            var result = Content($"{id} updated");
            if (FindPersonById(id) == -1)
            {
                result = Content($"{id} not found");
                result.StatusCode = 404;
            }
            else
                people[FindPersonById(id)] = person;

            return result;
        }


        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeletePersonById(int id, [FromHeader(Name = "X-AccessKey")] string key)
        {

            if (key != "123456789")
                return Unauthorized();
           
            if (FindPersonById(id) == -1)
            {
                return NotFound();
            }
            else
                people.RemoveAt(FindPersonById(id));

            var result = Content($"{id} deleted");
            result.StatusCode = 204;
            return result;
        }

        
    }
}