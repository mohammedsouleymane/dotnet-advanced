using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>
            {
                new (){Name = "Fifa 20",Genre = "sport",Pickorder = 1},
                new (){Name = "Fifa 20",Genre = "sport",Pickorder = 2}
            };
           
            foreach (var VARIABLE in games)
            {
                Console.WriteLine(VARIABLE.Name +" "+VARIABLE.Genre+" "+VARIABLE.Pickorder);
            }
        }
    }
}
