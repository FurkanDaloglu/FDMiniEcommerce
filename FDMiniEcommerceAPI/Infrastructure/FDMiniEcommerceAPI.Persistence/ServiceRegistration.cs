using Microsoft.EntityFrameworkCore;
using FDMiniEcommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using FDMiniEcommerceAPI.Application.Repositories.CustomerRepositories;
using FDMiniEcommerceAPI.Persistence.Repositories.CustomerRepositories;
using FDMiniEcommerceAPI.Application.Repositories.OrderRepositories;
using FDMiniEcommerceAPI.Persistence.Repositories.OrderRepositories;
using FDMiniEcommerceAPI.Application.Repositories.ProductRepositories;
using FDMiniEcommerceAPI.Persistence.Repositories.ProductRepositories;

namespace FDMiniEcommerceAPI.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddDbContext<FDMiniEcommerceAPIContext>(options => options.UseNpgsql(Configuration.ConnectionString));
			services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
			services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
			services.AddScoped<IOrderReadRepository,OrderReadRepository>();
			services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
			services.AddScoped<IProductReadRepository,ProductReadRepository>();
			services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
		}
	}
}
