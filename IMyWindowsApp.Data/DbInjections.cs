using IMyWindowsApp.Data.DB;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Data
{
    public static class DbInjections
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddSingleton<IDbContext, DbContext>();
            return services;
        }
    }
}
