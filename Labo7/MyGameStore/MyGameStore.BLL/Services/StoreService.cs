using MyGameStore.BLL.Interfaces;
using MyGameStore.DAL;
using MyGameStore.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGameStore.BLL.Services
{
    public class StoreService : IStore
    {
        private GameContext _context;

        public StoreService(GameContext context)
        {
            _context = context;
        }
        public void Add(Store store)
        {
            if(_context.tblStores.Contains(store))
                throw new Exception("Store already exist");
            _context.tblStores.Add(store);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            if (_context.tblStores.Find(id) == null )
                throw new Exception("Invalid id");
            if(_context.tblPeople.Where(p => p.StoreId == id).Count() > 0)
                throw new Exception("Store still has employees");
            _context.Remove(_context.tblStores.Find(id));
            _context.SaveChanges();
        }

        public List<Store> GetAll(Sort sort, SortBy sortBy, string city, string zipCode, int page, int pageLength)
        {
            IQueryable<Store> result = _context.tblStores;
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

        public Store GetbyId(int id)
        {
            if (_context.tblStores.Find(id) == null)
                throw new Exception("Invalid id");
            return _context.tblStores.Find(id);
        }

        public void Update(Store store)
        {
            if (!_context.tblStores.Contains(store))
                throw new Exception("Store doesn't exist");
            _context.Update(store);
            _context.SaveChanges();
        }

    }
}