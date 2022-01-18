using System;

namespace MyGameStore.DAL
{
    public class Store
    {
        public Store()
        {
        }

        public Store(int id, string name, string street, int num, string addition, string zip, string city,
            Boolean isFranchiseStore)
        {
            Id = id;
            Name = name;
            Street = street;
            Addition = addition;
            ZipCode = zip;
            City = city;
            IsFranchiseStore = isFranchiseStore;
            
        }

        public int Id { get; set; }

    
        public string Name { get; set; }

 
        public string Street { get; set; }

        public int Number { get; set; }


        public string Addition { get; set; }

   
        public string ZipCode { get; set; }


        public String City { get; set; }


        public Boolean IsFranchiseStore { get; set; }
    }
}