using ETıcaretAPI.Domain.Entities;
using ETıcaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETıcaretAPI.Persistance
{
     static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETıcaretAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }

        
    }
}
