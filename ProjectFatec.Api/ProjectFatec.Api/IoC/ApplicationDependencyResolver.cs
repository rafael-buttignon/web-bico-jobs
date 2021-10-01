﻿using Fatec.Domain.Repositories.Interfaces;
using Fatec.Domain.Repositories.Transaction;
using Fatec.Domain.Services;
using Fatec.Domain.Services.Clock;
using Fatec.Domain.Services.Interfaces;
using Fatec.Domain.Services.Interfaces.Clock;
using Fatec.Domain.Services.Interfaces.User;
using Fatec.Domain.Services.User;
using Fatec.Domain.ValueTypes.AppSettings;
using Fatec.Infrastructure.Context;
using Fatec.Infrastructure.Repositories;
using Fatec.Infrastructure.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectFatec.WebApi.Mapper;

namespace ProjectFatec.WebApi.IoC
{
    public static class ApplicationDependencyResolver
    {
        public static void GetDependencies(this IServiceCollection services, IAppSettings appSettings)
        {
            services.AddDbContext<BicoContext>(x =>
                x.UseSqlServer(appSettings.ConnectionStrings.BicoDbConnection,
                    y => y.MigrationsHistoryTable("MigrationHistory", "bico"))
            );

            services.AddSingleton(AutoMapperConfig.Register().CreateMapper());

            AddServices(services);
            AddRepositories(services);
            AddCommomHelperServices(services);
        }

        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
            services.AddScoped<IUserService, UserService>();
        }

        public static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        public static void AddCommomHelperServices(IServiceCollection services)
        {
            services.AddScoped<IClock, Clock>();
        }
    }
}
