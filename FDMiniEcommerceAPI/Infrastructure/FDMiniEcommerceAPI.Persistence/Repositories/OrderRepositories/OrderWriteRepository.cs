using FDMiniEcommerceAPI.Application.Repositories.OrderRepositories;
using FDMiniEcommerceAPI.Domain.Entites;
using FDMiniEcommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMiniEcommerceAPI.Persistence.Repositories.OrderRepositories
{
	public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
	{
		public OrderWriteRepository(FDMiniEcommerceAPIContext context) : base(context)
		{
		}
	}
}
