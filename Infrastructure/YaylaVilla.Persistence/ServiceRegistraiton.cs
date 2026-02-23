using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Persistence.Concrete;
using YaylaVilla.Persistence.Settings;

namespace YaylaVilla.Persistence
{
    public static class ServiceRegistraiton
    {
        public static void AddPersisitenceServices(this IServiceCollection services)
        {
            services.AddDbContext<YaylaVillaContext>(opt => opt.UseNpgsql(DatabaseSettings.ConnectionString), ServiceLifetime.Scoped);
        }
    }
}
