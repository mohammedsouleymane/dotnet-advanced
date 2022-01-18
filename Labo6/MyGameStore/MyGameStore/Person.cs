using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(int id, string lastName, string firstName, int gender, string email, int storeId)
        {
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Email = email;
            StoreId = storeId;
            store = null;
        }

        public int Id { get; set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Gender { get; set; }
 
        public string Email { get; set; }

        public int? StoreId { get; set; }

        private Store store  { get; set; }
    }
}
