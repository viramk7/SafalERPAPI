using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SafalERP.Entities.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafalERP.API.Core.Extensions
{
    public static class ConfigureAutoMapperExtension
    {
        public static IServiceCollection ConfigureAutoMapper(this IServiceCollection services)
        {

            services.AddSingleton(new MapperConfiguration(c =>
            {
                c.AddProfile(new Mappings());
            }).CreateMapper());

            return services;
        }
    }
}
