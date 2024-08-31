using FDMiniEcommerceAPI.Application.Repositories.ProductRepositories;
using FDMiniEcommerceAPI.Domain.Entites;
using FDMiniEcommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMiniEcommerceAPI.Persistence.Repositories.ProductRepositories
{
	public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
	{
		public ProductReadRepository(FDMiniEcommerceAPIContext context) : base(context)
		{
		}
	}
}
