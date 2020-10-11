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
using SampleWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SampleWebAPI
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
            //services.AddDbContext<TestContext>(opt => opt.UseInMemoryDatabase("TestContext"));// for DI
            services.AddSingleton<TestContext>();            
            services.AddControllers();
            services.AddCors();
            services.AddControllers().AddNewtonsoftJson();
            //Register the swagger generator ,defining one or more swagger documents
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // enable cors
            app.UseCors(a =>a.SetIsOriginAllowed(x =>_ = true).AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            // Enable middleware to serve generated swagger as a JSON end point
            app.UseSwagger();
            // ENable middleware to serve swagger-ui (HTML,JS,CSS etc),
            // specifying the swagger JSON endpoint

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
