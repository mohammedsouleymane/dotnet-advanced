using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyGameStore.Configurations;

namespace MyGameStore.DAL
{
    public class GameContext: DbContext
    {
        public DbSet<Store> tblStores { get; set; }

        public DbSet<Person> tblPeople { get; set; }

        public GameContext(DbContextOptions dbContextOptions) : base((dbContextOptions))
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new StoreConfig());

            modelBuilder.Entity<Store>().PushData();

            //modelBuilder.Entity<Store>().HasData(new Store(2,"StoreTwo", "ELL","", "2060", "Antwerpen",
            //    true,1));
            modelBuilder.Entity<Person>().PushData();
        }
    }
}
