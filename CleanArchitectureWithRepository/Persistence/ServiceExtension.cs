using Application.Interfaces;
using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceExtension
    {
        public static void AddPersistence(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
                configuration.GetConnectionString("DefaultConnectionString")
                ));
            service.AddScoped<IApplicationDbContext,ApplicationDbContext>();
            service.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            //service.AddTransient<IProductRepository, ProductRepository>();
                service.AddTransient<IProductRepository, ProductRepository>();


        }
    }
}
