using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL;

using MyGameStore.DAL.UOW;
using MyGameStore.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.BLL.Services
{
    public class StoreService : IStore
    {
        private IUnitOfWork _unitOfWork;

        public StoreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Store store)
        {
            _unitOfWork.StoreRepository.Create(store);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _unitOfWork.StoreRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public List<Store> GetAll(Sort sort, SortBy sortBy, string city, string zipCode, int page, int pageLength)
        {
            return _unitOfWork.StoreRepository.GetAll(sort, sortBy, city, zipCode, page, pageLength).ToList();
        }

        public Store GetbyId(int id)
        {
            return _unitOfWork.StoreRepository.GetById(id);
        }

        public void Update(Store store)
        {
            _unitOfWork.StoreRepository.Update(store);
            _unitOfWork.Commit();
        }

    }
}