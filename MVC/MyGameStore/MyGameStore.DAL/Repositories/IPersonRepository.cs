using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.DAL.Repositories
{
    public interface IPersonRepository
    {
        public IEnumerable<Person> GetAll();

        public Person GetById(int id);  

        public void Create(Person person);
        public void Update(Person modifiedPerson);

        public void Delete(int id);
    }
}
