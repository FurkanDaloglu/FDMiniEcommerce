using FDMiniEcommerceAPI.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDMiniEcommerceAPI.Persistence.Contexts
{
	public class FDMiniEcommerceAPIContext : DbContext
	{
		public FDMiniEcommerceAPIContext(DbContextOptions options) : base(options)
		{
		}

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
