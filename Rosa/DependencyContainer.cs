using BLL;
using BLL.interfaces;
using DAL.DataAccessLayers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

using DAL.DataAccessLayers;
using BLL.Interfaces;

//Class Called inside Startup.cs to Dependency injection
namespace Rosa
{
    public static class DependencyContainer
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductBLL, ProductBLL>();
            services.AddScoped<IProductDal, ProductDal>();
            services.AddScoped<IProductTypeBLL, ProductTypeBLL>();
            services.AddScoped<IProductTypeDal, ProductTypeDal>();
            services.AddScoped<IProductPropertyBLL, ProductPropertyBLL>();
            services.AddScoped<IProductPropertyDal, ProductPropertyDal>();
            services.AddScoped<IOrderBLL, OrderBLL>();
            services.AddScoped<IOrderDal, OrderDal>();

        }
    }
}
