using MyGameStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.BLL.Interfaces
{
    public enum Sort { Ascending = 1, Descending }
    public enum SortBy { Name = 1, Zip }
    public interface IStore
    {
        public List<Store> GetAll(Sort sort, SortBy sortBy, string city, string zipCode, int page, int pageLength);

        public Store GetbyId(int id);

        public void Add(Store store);

        public void Update(Store store);

        public void Delete(int id);
    }
}
