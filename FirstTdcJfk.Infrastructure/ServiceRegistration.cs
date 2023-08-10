using FirstTdcJfk.Application.Interfaces;
using FirstTdcJfk.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTdcJfk.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ITdcRepository, TdcRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}