using FDMiniEcommerceAPI.Application.Repositories.CustomerRepositories;
using FDMiniEcommerceAPI.Domain.Entites;
using FDMiniEcommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMiniEcommerceAPI.Persistence.Repositories.CustomerRepositories
{
	public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
	{
		public CustomerReadRepository(FDMiniEcommerceAPIContext context) : base(context)
		{
		}
	}
}
