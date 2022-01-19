
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGameStore.DAL;

namespace MyGameStore.BLL.Interfaces
{
    public interface IPerson
    {
        public List<Person> GetAll();

        public Person GetbyId(int id);

        public void Add(Person person);

        public void Update(Person person);

        public void Delete(int id);
    }
}
