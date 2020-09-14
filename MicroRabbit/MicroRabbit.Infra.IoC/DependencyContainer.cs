﻿using MicroRabbit.Domain.Core.Bus;
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
        }
    }
}