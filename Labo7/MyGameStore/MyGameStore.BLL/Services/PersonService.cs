using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL;
using MyGameStore.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.BLL.Services
{
    public class PersonService : IPerson
    {
        private GameContext _context;

        public PersonService(GameContext context)
        {
            _context = context;
        }
        public void Add(Person person)
        {
            if (_context.tblPeople.Contains(person))
                throw new Exception("Person already exist");
            _context.tblPeople.Add(person);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_context.tblPeople.Find(id) == null)
                throw new Exception("Invalid id");
            _context.Remove(_context.tblPeople.Find(id));
            _context.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return _context.tblPeople.ToList();
        }

        public Person GetbyId(int id)
        {
            if (_context.tblPeople.Find(id) == null)
                throw new Exception("Invalid id");
            return _context.tblPeople.Find(id);
        }

        public void Update(Person person)
        {
            if (!_context.tblPeople.Contains(person))
                throw new Exception("Invalid person");
            _context.Update(person);
            _context.SaveChanges();
        }
    }
}
