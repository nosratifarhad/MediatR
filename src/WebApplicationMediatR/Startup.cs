using MediatR;
using Microsoft.OpenApi.Models;
using WebApplicationMediatR.Domain;
using WebApplicationMediatR.Repository;

namespace WebApplicationMediatR
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
            services.AddScoped<IProductRepository, ProductRepository>();

            #region [ MediatR ]

            ///Install nuget package
            ///
            ///dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
            ///OR
            ///NuGet\Install-Package MediatR.Extensions.Microsoft.DependencyInjection -Version 11.1.0
            ///

            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //you can use 
            //
            //services.AddMediatR(AppDomain.CurrentDomain.Load("WebApplicationMediatR"));
            //or
            services.AddMediatR(typeof(Program).Assembly);
            //or
            //services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(ITestService).Assembly);

            #endregion [ MediatR ]

            services.AddControllers();

            #region [ Swagger ]
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplicationMediatR", Version = "v1" });
            });
            #endregion [ Swagger ]
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplicationMediatR v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

}