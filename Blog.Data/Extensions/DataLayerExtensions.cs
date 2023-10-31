using Blog.Data.Repositiries.Abstraction;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog.Data.Context;
using Blog.Data.UnitofWorks;

namespace Blog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); // burda IRepository çağırmak için istek yolladığımızda bize Repository olarak döndürücek.
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            //builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            //Yukarıda ki kod program.cs teki hali!
            services.AddScoped<IUnitofWork, UnitofWork>();
            return services;
        }   
    }
}
