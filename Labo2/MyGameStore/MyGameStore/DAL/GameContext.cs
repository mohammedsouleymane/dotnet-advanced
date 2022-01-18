using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MyGameStore.DAL
{
    public class GameContext: DbContext
    {
        public DbSet<Store> Stores { get; set; }

        public DbSet<Person> People { get; set; }

        public GameContext(DbContextOptions dbContextOptions) : base((dbContextOptions))
        {
            
        }
    }
}
