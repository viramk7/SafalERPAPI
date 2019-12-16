﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SafalERP.API.Core.Extensions;
using SafalERP.Entities.DbContexts;

namespace SafalERP.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        readonly string AllowedOrigins = "_AllowedOrigins";
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Add DB refrence
            services.AddDbContext<SafalERPDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("SafalERPDB")));

            services.AddCors(option =>
            {
                option.AddPolicy(AllowedOrigins, buider =>
                {
                    buider.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });

            services.ConfigureAutoMapper();

            services.ConfigureMVC();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(AllowedOrigins);

            app.UseHttpsRedirection();

            app.UseMvc();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
