using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGameStore.Configurations
{
    public static class Extensions
    {
        public static void PushData(this EntityTypeBuilder<Store> builder )
        {
            builder.HasData(new Store(1, "test", "ELL", "", "2060", "Antwerpen",
                true, 1));
        }

        public static void PushData(this EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person(1, "Souleymane", "Mohammed", 2, "s120720@ap.be", 1));
        }
    }
}
