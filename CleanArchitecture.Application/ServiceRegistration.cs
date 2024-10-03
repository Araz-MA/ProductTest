using System.Reflection;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.Public;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Application.Common.Mapping;


namespace CleanArchitecture.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddScoped<IRedisManager, Redis>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            //services.AddStackExchangeRedisCache(options =>
            //{
            //    options.Configuration = configuration.GetConnectionString("Redis");
            //    options.InstanceName = Path.GetFileNameWithoutExtension(System.Diagnostics.Process.GetCurrentProcess().MainModule?.FileName) + "_";
            //});
        }


    }
}