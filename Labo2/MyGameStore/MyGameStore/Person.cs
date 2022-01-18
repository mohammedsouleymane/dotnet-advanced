using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public Person(int id, string lastName, string firstName, char gender, string email,int storeId)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Email = email;
            GameStoreId = storeId;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private Char gender;

        public Char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [ForeignKey("gameStoreId")]
        private int gameStoreId;
        public int GameStoreId
        {
            get { return gameStoreId; }
            set { gameStoreId = value; }
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Gender}";
        }
    }
}
