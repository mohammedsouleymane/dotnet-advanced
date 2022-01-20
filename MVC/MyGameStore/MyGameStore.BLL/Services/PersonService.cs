using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL;
using MyGameStore.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MyGameStore.BLL.Services
{
    public class PersonService : IPerson
    {
        private IUnitOfWork _unitOfWork;
        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Person person)
        {
            if (_unitOfWork.StoreRepository.GetById((int)person.StoreId) == null)
                throw new Exception("Store id doesn't exist");
            _unitOfWork.PersonRepository.Create(person);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            if (GetbyId(id) == null)
                throw new Exception("Person not found");
            _unitOfWork.PersonRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<Person> GetAll()
        {
            return _unitOfWork.PersonRepository.GetAll().ToList();
        }

        public Person GetbyId(int id)
        {
            return _unitOfWork.PersonRepository.GetById(id);
        }

        public void Update(Person person)
        {
            _unitOfWork.PersonRepository.Update(person);
            _unitOfWork.Commit();
        }
    }
}
