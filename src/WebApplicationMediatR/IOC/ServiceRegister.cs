using WebApplicationMediatR.Service;
using WebApplicationMediatR.Service.Contracts;

namespace WebApplicationMediatR.IOC
{
    public static class ServiceRegister
    {
        public static void AddWebApplicationMediatRService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
