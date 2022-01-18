using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(int id, string lastName, string firstName, char gender)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
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

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Gender}";
        }
    }
}
