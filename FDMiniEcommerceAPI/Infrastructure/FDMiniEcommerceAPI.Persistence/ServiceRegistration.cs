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
			services.AddDbContext<FDMiniEcommerceAPIContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
			services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
			services.AddSingleton<ICustomerWriteRepository,CustomerWriteRepository>();
			services.AddSingleton<IOrderReadRepository,OrderReadRepository>();
			services.AddSingleton<IOrderWriteRepository,OrderWriteRepository>();
			services.AddSingleton<IProductReadRepository,ProductReadRepository>();
			services.AddSingleton<IProductWriteRepository,ProductWriteRepository>();
		}
	}
}
