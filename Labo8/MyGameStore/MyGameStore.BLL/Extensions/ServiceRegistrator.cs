using Microsoft.Extensions.DependencyInjection;
using MyGameStore.BLL.Interfaces;
using MyGameStore.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameStore.BLL.Extensions
{
    public static class ServiceRegistrator
    {
        public static  IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPerson, PersonService>();
            services.AddScoped<IStore, StoreService>();

            return services;
        }
    }
}
