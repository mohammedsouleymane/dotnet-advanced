using MyGameStore.DAL.DAL;
using MyGameStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private GameContext _gameContext;
        private IPersonRepository _personRepository;
        private IStoreRepository _storeRepository;
        
        public UnitOfWork(GameContext gameContext, IPersonRepository personRepository, IStoreRepository storeRepository)
        {
             _gameContext = gameContext;
            _personRepository = personRepository;
            _storeRepository = storeRepository;
        }

        public IPersonRepository PersonRepository { get { return _personRepository; } }

        public IStoreRepository StoreRepository {get { return _storeRepository; } }

        public int Commit()
        {
            return _gameContext.SaveChanges();
        }
    }
}
