using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlibrary
{
   public class PlayerFine
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerInitials { get; set; }

        public string PlayerStreet { get; set; }
        public string PlayerHouseNumber { get; set; }
        public string PlayerZipcode { get; set; }
        public string PlayerLocation { get; set; }
        public int NumberOfFines { get; set; }
    }
}
