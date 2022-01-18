using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyGameStore.DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.DAL.Extensions
{

    public static class DALRegistrator
    {
        public static IServiceCollection RegisterContexts(this IServiceCollection services)
        {

            services.AddDbContext<GameContext>(options => options.UseSqlServer("name=ConnectionStrings:GameStore"));

            return services;
        }
    }
}
