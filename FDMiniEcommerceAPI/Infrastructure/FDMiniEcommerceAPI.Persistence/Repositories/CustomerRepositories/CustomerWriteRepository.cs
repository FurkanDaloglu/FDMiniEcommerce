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
	public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
	{
		public CustomerWriteRepository(FDMiniEcommerceAPIContext context) : base(context)
		{
		}
	}
}
