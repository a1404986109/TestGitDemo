using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ghy.Core.EntityFramework.Dto;
using Ghy.Core.Service;
using Ghy.Core.Dal;
using Ghy.Core.EntityFramework.EntityModel;

namespace Ghy.Core.Web.Api.Sealed
{
    public class IRegisteIoc
    {
        public static void RegisteIoc(IServiceCollection services)
        {
            services.AddScoped<DbContext,DbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<user>, Repository<user>>();
            services.AddScoped<IRepository<account>, Repository<account>>();
            services.AddScoped<IRepository<a>, Repository<a>>();
            services.AddScoped<IRepository<api>, Repository<api>>();
            services.AddScoped<CreateModelService,CreateModelService>();
            services.AddScoped<UserService, UserService>();
            services.AddScoped<AccountService, AccountService>();
            services.AddScoped<ApiService, ApiService>();
            services.AddScoped<AService, AService>();
        }
    }
}
