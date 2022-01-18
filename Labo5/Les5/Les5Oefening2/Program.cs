using System;
using System.Linq;
using classlibrary;

namespace Les5Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Oefening 1");
            foreach (var player in Players.GetPlayers().Where(n => n.DateOfBirth.Year > 1969))
            {
                Console.WriteLine($"{player.Id} {player.LastName} {player.DateOfBirth}");
            }
            //2
            Console.WriteLine("\n Oefening 2");
            foreach (var player in Players.GetPlayers().Where(n => n.DateOfBirth.Year > 1969).OrderByDescending(n => n.DateOfBirth))
            {
                Console.WriteLine($"{player.Id} {player.LastName} {player.DateOfBirth}");
            }

            //3
            Console.WriteLine("\n Oefening 3");
            foreach (var player in Players.GetPlayers().OrderBy(n => n.LastName).ThenBy(n => n.DateOfBirth))
            {
                Console.WriteLine($"{player.Id} {player.LastName} {player.DateOfBirth}");
            }

            //4
            Console.WriteLine("\n Oefening 4");
            foreach (var player in Players.GetPlayers().Where(n => n.Fines.Count > 0))
            {
                Console.WriteLine($"{player.Id} {player.LastName} {player.DateOfBirth}");
                foreach (var fine in player.Fines)
                {
                    Console.WriteLine($"\t {fine.Id} {fine.Amount}");
                }
                
            }
            //5
            Console.WriteLine("\n Oefening 5");
            foreach (var player in Players.GetPlayers().Where(n => n.Fines.Count > 0))
            {
                Console.WriteLine($"{player.LastName} {player.Fines.Max(n => n.Amount)}");
            }

            Console.WriteLine();
            foreach (var player in from player in Players.GetPlayers() where player.Fines.Count > 0 select player)
            {
                Console.WriteLine($"{player.LastName} {(from fine in player.Fines select fine.Amount).Max()}");
            }

            //6
            Console.WriteLine("\n Oefening 6");
            foreach (var player in Players.GetPlayers())
            {
                Console.WriteLine($"{player.LastName} {player.Fines.Sum(n => n.Amount)}");
            }


            //7
            Console.WriteLine("\n Oefening 7");
            foreach (var player in Players.GetPlayers().Where(n => n.Fines.Count > 0).OrderByDescending(n => n.Fines.Sum(x => x.Amount)))
            {
                Console.WriteLine($"{player.LastName} {player.Fines.Sum(n => n.Amount)}");
            }

            //8
            Console.WriteLine("\n Oefening 8");
            var oldest = Players.GetPlayers().OrderBy(n => n.DateOfBirth).First();
            Console.WriteLine(oldest.LastName + " " + oldest.DateOfBirth+"\n");

            //9
            Console.WriteLine("\n Oefening 9");
            foreach (var player in Players.GetPlayers().Where(n => n.DateOfBirth.Year >= 1955))
            {
                Console.WriteLine($"{player.LastName} {player.DateOfBirth} {player.Fines.Count}");
                player.Fines.ForEach(n => Console.WriteLine($"\t{n.Amount}"));
            }


            //10
            Console.WriteLine("\n Oefening 10");
            foreach (var group in Players.GetPlayers().GroupBy(n => n.DateOfBirth.Year))
            {
                Console.WriteLine($"{group.Key} {group.Count()} {group.Sum(player => player.Fines.Sum(n => n.Amount))}");
                foreach (var player in group)
                {
                    Console.WriteLine($"\t{player.LastName} ");
                }
            }
        }

        
    }
}
