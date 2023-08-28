using Jfk.Tc.Decn.Application.Interfaces;
using Jfk.Tc.Decn.Application.Services;
using Jfk.Tc.Decn.Infrastructure.Adapters;
using Jfk.Tc.Decn.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jfk.Tc.Decn.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICreditCardRepository, CreditCardRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDecisionMotorServices, DecisionMotorServices>();
            services.AddTransient<IDecisionMotorAdapter, DecisionMotorAdapter>();
            services.AddScoped<ICreditCardService, CreditCardService>();
        }
    }
}