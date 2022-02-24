using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Simple_API.Api.Middleware;
using Simple_API.Domain.Classes;
using Simple_API.Domain.Respositories;
using Simple_API.Infrastructure;
using Simple_API.Infrastructure.DTOs;
using Simple_API.Infrastructure.Mock;
using Simple_API.Infrastructure.ORM.JsonFile.Repositories;
using Simple_API.Infrastructure.Services;

namespace Simple_API.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Simple_API.Api", Version = "v1" });
            });
            services.AddScoped<IDeviceRepository<TrafficLights>, TrafficLampsRepository>();
            services.AddScoped<IDeviceRepository<AggregateCamera>, CameraRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Simple_API.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            FillTheJsonFile.FillData();

        }
    }
}