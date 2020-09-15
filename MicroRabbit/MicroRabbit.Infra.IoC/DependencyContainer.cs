using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
   public class DependencyContainer
    {
        public static void RegisteryServices(IServiceCollection services)
        {
            //Domain bus 
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Layer
            services.AddTransient<IAccountService,AccountService>();

            //data layer
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<BankingDbContext>();
        }
    }
}
