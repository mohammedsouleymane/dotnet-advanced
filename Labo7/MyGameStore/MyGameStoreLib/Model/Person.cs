namespace MyGameStoreLib
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(int id, string lastName, string firstName, int gender, string email, int storeId)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Email = email;
            StoreId = storeId;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Gender { get; set; }
 
        public string Email { get; set; }

        public int? StoreId { get; set; }
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Gender}";
        }

        public Store store  { get; set; }
    }
}
