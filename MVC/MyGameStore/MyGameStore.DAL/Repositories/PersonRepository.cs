using MyGameStore.DAL.DAL;
using System;
using System.Collections.Generic;

namespace MyGameStore.DAL.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private GameContext _gameContext;
        public PersonRepository(GameContext gameContext)
        {
            _gameContext = gameContext;
        }
        public void Create(Person person)
        {
            _gameContext.tblPeople.Add(person);
        }

        public void Delete(int id)
        {
            _gameContext.Remove(GetById(id));
        }

        public IEnumerable<Person> GetAll()
        {
            return _gameContext.tblPeople;
        }

        public Person GetById(int id)
        {
            return _gameContext.tblPeople.Find(id);
        }

        public void Update(Person modifiedPerson)
        {
            _gameContext.tblPeople.Update(modifiedPerson);
        }
    }
}
