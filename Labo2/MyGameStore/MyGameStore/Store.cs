using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore
{
    public class Store
    {

        public Store()
        {
            
        }

        public Store(int id, string name, string street, string addition, string zip, string city, Boolean isFranchiseStore)
        {
            Id = id;
            Name = name;
            Street = street;
            Addition = addition;
            ZipCode = zip;
            City = city;
            IsFranchiseStore = isFranchiseStore;

        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private String street;

        public String Street
        {
            get { return street; }
            set { street = value; }
        }
        private String addition;

        public String Addition
        {
            get { return addition; }
            set { addition = value; }
        }

        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private String city;

        public String City
        {
            get { return city; }
            set { city = value; }
        }

        private Boolean isFranchiseStore;

        public Boolean IsFranchiseStore
        {
            get { return isFranchiseStore; }
            set { isFranchiseStore = value; }
        }
    }
}
