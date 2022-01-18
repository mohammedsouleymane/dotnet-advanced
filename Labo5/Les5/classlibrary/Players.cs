using System;
using System.Collections.Generic;


namespace classlibrary
{
    public class Players
    {
         #region Private methods

        public static List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>
            {
                new Player{Id=2,LastName="Elfring",Initials="R",DateOfBirth=new DateTime(1984,9,1),Gender='M',YearOfJoining=1975,Street="Steden",Number="43",ZipCode="3575NH",City="Den Haag",Phone="070-476537",FederationNr="2411",Fines=new List<Fine>{}},
                new Player{Id=6,LastName="Permentier",Initials="R",DateOfBirth=new DateTime(1964,6,25),Gender='M',YearOfJoining=1977,Street="Hazensteinln",Number="80",ZipCode="1234KK",City="Den Haag",Phone="070-476537",FederationNr="8467",Fines=new List<Fine>{new Fine { Id=1,PlayerId=6,Date=new DateTime(1980,12,08),Amount=100M}}},
                new Player{Id=7,LastName="Wijers",Initials="GWS",DateOfBirth=new DateTime(1963,5,11),Gender='M',YearOfJoining=1981,Street="Erasmusweg",Number="39",ZipCode="9758VB",City="Den Haag",Phone="070-347689",FederationNr="",Fines=new List<Fine>{}},
                new Player{Id=8,LastName="Niewenburg",Initials="B",DateOfBirth=new DateTime(1962,7,8),Gender='V',YearOfJoining=1980,Street="Spoorlaan",Number="4",ZipCode="6584WO",City="Rijswijk",Phone="070-458458",FederationNr="2983",Fines=new List<Fine>{new Fine { Id=6,PlayerId=8,Date=new DateTime(1980,12,8),Amount=25M}}},
                new Player{Id=27,LastName="Cools",Initials="DD",DateOfBirth=new DateTime(1964,12,28),Gender='V',YearOfJoining=1983,Street="Liespad",Number="804",ZipCode="8457DK",City="Zoetermeer",Phone="079-234857",FederationNr="",Fines=new List<Fine>{new Fine { Id= 3,PlayerId=27,Date=new DateTime(1983,9,10),Amount=100M},new Fine { Id=8,PlayerId=27,Date=new DateTime(1984,11,12),Amount=75M}}},
                new Player{Id=28,LastName="Cools",Initials="C",DateOfBirth=new DateTime(1963,06,22),Gender='V',YearOfJoining=1983,Street="Oudegracht",Number="10",ZipCode="1294QK",City="Leiden",Phone="010-659599",FederationNr="",Fines=new List<Fine>{}},
                new Player{Id=39,LastName="Bischoff",Initials="B",DateOfBirth=new DateTime(1965,10,29),Gender='M',YearOfJoining=1980,Street="Ericaplein",Number="78",ZipCode="9629CD",City="Den Haag",Phone="070-393435",FederationNr="",Fines=new List<Fine>{}},
                new Player{Id=44,LastName="Bakker, de",Initials="E",DateOfBirth=new DateTime(1963,1,9),Gender='M',YearOfJoining=1980,Street="Lawaaistraat",Number="23",ZipCode="4444LJ",City="Rijswijk",Phone="070-368753",FederationNr="1124",Fines=new List<Fine>{new Fine { Id=2,PlayerId=44,Date=new DateTime(1981,5,5),Amount=75M},new Fine { Id=5,PlayerId=44,Date=new DateTime(1980,12,8),Amount=25M},new Fine { Id=7,PlayerId=44,Date=new DateTime(1982,12,30),Amount=30M}}},
                new Player{Id=57,LastName="Bohemen, van",Initials="M",DateOfBirth=new DateTime(1971,8,17),Gender='M',YearOfJoining=1985,Street="Erasmusweg",Number="16",ZipCode="4377CB",City="Den Haag",Phone="070-473458",FederationNr="6409",Fines=new List<Fine>{}},
                new Player{Id=83,LastName="Hofland",Initials="PK",DateOfBirth=new DateTime(1956,11,11),Gender='M',YearOfJoining=1982,Street="Mariakade",Number="16a",ZipCode="1812UP",City="Den Haag",Phone="070-353548",FederationNr="1608",Fines=new List<Fine>{}},
                new Player{Id=95,LastName="Meuleman",Initials="P",DateOfBirth=new DateTime(1963,5,14),Gender='M',YearOfJoining=1972,Street="Hoofdweg",Number="33a",ZipCode="5746OP",City="Voorburg",Phone="070-867564",FederationNr="",Fines=new List<Fine>{}},
                new Player{Id=100,LastName="Permentier",Initials="P",DateOfBirth=new DateTime(1963,2,28),Gender='M',YearOfJoining=1979,Street="Hazensteinln",Number="80",ZipCode="6494SG",City="Den Haag",Phone="070-494593",FederationNr="6524",Fines=new List<Fine>{}},
                new Player{Id=104,LastName="Moerman",Initials="D",DateOfBirth=new DateTime(1970,5,10),Gender='V',YearOfJoining=1984,Street="Stoutlaan",Number="65",ZipCode="9437AO",City="Zoetermeer",Phone="079-987571",FederationNr="7060",Fines=new List<Fine>{new Fine { Id=4,PlayerId=104,Date=new DateTime(1984,12,8),Amount=50M}}},
                new Player{Id=112,LastName="Baalen, van",Initials="IP",DateOfBirth=new DateTime(1963,10,1),Gender='V',YearOfJoining=1984,Street="Vosseweg",Number="8",ZipCode="6392LK",City="Rotterdam",Phone="010-548745",FederationNr="1319",Fines=new List<Fine>{}}
            };

            return players;
        }

        #endregion
    }
}
