using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using MyGameStore.DAL;

namespace MyGameStore.Controllers
{
    public enum Sort {Ascending=1, Descending }
    public enum SortBy { Name=1, Zip }
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
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.tblStores.FirstOrDefault(ed => ed.Id == id);

            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult Get(Sort sort, SortBy sortBy, string city, string zipCode, int page=1, int pageLength=10)
        {         
            IQueryable<Store> result = _context.tblStores; 

            if (page > 0 && pageLength > 0)
            {
                result = result.Skip(page * pageLength).Take(pageLength);
            }

            if (!string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(zipCode))
            {
                result = result.Where(n => n.City == city || n.ZipCode == zipCode);
            }
            if ((int)sort != 0 || (int)sortBy != 0 )
            {              
                if (sort != Sort.Ascending)
                {
                    if (sortBy == SortBy.Name)
                        result = result.OrderByDescending(n => n.Name);
                    else if (sortBy == SortBy.Zip)
                        result = result.OrderByDescending(n => n.ZipCode);
                }
                else
                {
                    if (sortBy == SortBy.Name)
                        result = result.OrderBy(n => n.Name);
                    else if (sortBy == SortBy.Zip)
                        result = result.OrderBy(n => n.ZipCode);
                }
            }                                   
            if (!result.Any())
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
            Store store = new() { Id = id };
            _context.Remove(store);
            _context.SaveChanges();
            return Ok();
        }
    }
}
