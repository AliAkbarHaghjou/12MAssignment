using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleCrud.Application.Repositories;
using SimpleCrud.Persistence.Context;
using SimpleCrud.Persistence.Repositories;
using SimpleCrud.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<ISTIRepository, STIRepository>();
            services.AddTransient<ISTKRepository, STKRepository>();
        }
    }
}