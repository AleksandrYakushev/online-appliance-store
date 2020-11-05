using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineApplianceStore.API.Configuration;
using OnlineApplianceStore.Core;

namespace OnlineApplianceStore.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json");

            if (webHostEnvironment.IsDevelopment())
            {
                builder.AddJsonFile("appsettings.Development.json");
            }
            if (webHostEnvironment.IsEnvironment("Testing"))
            {
                builder.AddJsonFile("appsettings.Testing.json");
            }

            Configuration = builder.Build();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<AutofacConfig>();
        }


        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.Configure<DBSettings>(Configuration);
            //services.Configure<UrlSettings>(Configuration);
            services.AddSwaggerGen();
            services.AddControllersWithViews();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
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
