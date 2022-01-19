using MyGameStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.DAL.UOW
{
    public interface IUnitOfWork
    {
        public int Commit();

        public IPersonRepository PersonRepository { get;}
        public IStoreRepository StoreRepository { get; }
    }
}
