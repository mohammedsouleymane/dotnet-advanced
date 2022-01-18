using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyGameStore.DAL.DAL;
using MyGameStore.DAL.Repositories;
using MyGameStore.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.DAL.Extensions
{

    public static class DALRegistrator
    {
        public static IServiceCollection RegisterDataAcessServices(this IServiceCollection services)
        {
            services.RegisterContexts();
            services.RegisterRepositories();
            services.RegisterUnitOfWork();
            return services;
        }
        private static IServiceCollection RegisterContexts(this IServiceCollection services)
        {

            services.AddDbContext<GameContext>(options => options.UseSqlServer("name=ConnectionStrings:GameStore"));

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            return services;
        }

        private static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
