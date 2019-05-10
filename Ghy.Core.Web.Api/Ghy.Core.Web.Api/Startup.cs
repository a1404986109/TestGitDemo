﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Ghy.Core.Web.Api.Sealed;
using Ghy.Core.Web.Api.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace Ghy.Core.Web.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)//, IHostingEnvironment env)
        {
            Configuration = configuration;
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(env.ContentRootPath)
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //this.Configuration = builder.Build();
            //BaseConfigModel.SetBaseConfig(Configuration, env.ContentRootPath, env.WebRootPath);
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ApiActionFilter));
                options.Filters.Add(new ActionFilter());
                options.Filters.Add(new ValidationModelAttribute());
                options.Filters.Add<ExceptionFilter>();
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            IRegisteIoc.RegisteIoc(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
