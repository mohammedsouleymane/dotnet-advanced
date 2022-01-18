using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlibrary
{
    public class Player
    {
        #region Properties

        public int Id { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public int YearOfJoining { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string FederationNr { get; set; }
        public List<Fine> Fines { get; set; }
        
        #endregion
    }
}
