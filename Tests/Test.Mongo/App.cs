﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Test.Mongo
{
    internal class App
    {
        public static Lazy<IHost> Instance = new(static () =>
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbqMongo((s, o) => {
                        //o.Queue.StackMode = true;
                    });

                    services.AddScoped<Test.Common.Tests>();
                });

            return builder.Build();
        });

    }
}
