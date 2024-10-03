using CleanArchitecture.Domain.Entities.IdentityEntities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Common.Utilities;


namespace CleanArchitecture.WebCommon.Identity
{
    public static class IdentityExtensions
    {
        public static void AddCustomIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            //var settings = configuration.GetSection("SiteSettings").Get<SiteSettings>();//*
            services.AddIdentity<User, Role>(options => {
                options.Password.RequireDigit = true;   
            });
        }
    }
}
