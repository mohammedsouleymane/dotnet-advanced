using MyGameStore.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.DAL.Repositories
{
    public enum Sort { Ascending = 1, Descending }
    public enum SortBy { Name = 1, Zip }
    public class StoreRepository : IStoreRepository
    {
        private GameContext _gameContext;
        public StoreRepository(GameContext gameContext)
        {
            _gameContext = gameContext;
        }
        public void Create(Store store)
        {
            _gameContext.tblStores.Add(store);
        }

        public void Delete(int id)
        {
            Store store = new() { Id = id };
            _gameContext.Remove(store);
        }

        public IEnumerable<Store> GetAll(Sort sort, SortBy sortBy, string city, string zipCode, int page, int pageLength)
        {
            IQueryable<Store> result = _gameContext.tblStores;
            if (page > 0 && pageLength > 0)
            {
                result = result.Skip(--page * pageLength).Take(pageLength);
            }
            if (!string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(zipCode))
            {
                result = result.Where(n => n.City == city || n.ZipCode == zipCode);
            }
            if (sort != 0 || sortBy != 0)
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
                return null;
            return result.ToList();
        }

        public Store GetById(int id)
        {
            return _gameContext.tblStores.Find(id);
        }

        public void Update(Store modifiedStore)
        {
            _gameContext.tblStores.Update(modifiedStore);
        }
    }
}
