using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Reflection;

namespace OnlineApplianceStore.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
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

        //public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        //{
        //    var builder = new ConfigurationBuilder();

        //    builder.AddJsonFile("appsettings.json");

        //    if (webHostEnvironment.IsDevelopment())
        //    {
        //        builder.AddJsonFile("appsettings.Development.json");
        //    }
        //    if (webHostEnvironment.IsEnvironment("Testing"))
        //    {
        //        builder.AddJsonFile("appsettings.Testing.json");
        //    }

        //    Configuration = builder.Build();
        //}


        //public void ConfigureContainer(ContainerBuilder builder)
        //{
        //    //builder.RegisterModule<AutofacConfig>();
        //}

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddControllers();
        //    services.AddSwaggerGen(c =>
        //    {
        //        c.SwaggerDoc("v1",
        //            new Microsoft.OpenApi.Models.OpenApiInfo
        //            {
        //                Version = "v1",
        //                Title = "Online Application Store API"
        //            });
        //        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        //        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        //        c.IncludeXmlComments(xmlPath);
        //    });
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    }
}
