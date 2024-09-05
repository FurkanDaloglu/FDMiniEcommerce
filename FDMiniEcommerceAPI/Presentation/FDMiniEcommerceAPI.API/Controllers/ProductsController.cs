﻿using FDMiniEcommerceAPI.Application.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FDMiniEcommerceAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductReadRepository _productReadRepository;
		private readonly IProductWriteRepository _productWriteRepository;

		public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
		{
			_productReadRepository = productReadRepository;
			_productWriteRepository = productWriteRepository;
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok("Merhaba");
			//await _productWriteRepository.AddRangeAsync(new()
			//{
			//	new() { Id=Guid.NewGuid(), Name="Product 1", Price =100, CreatedDate=DateTime.UtcNow,Stock=10 },
			//	new() { Id=Guid.NewGuid(), Name="Product 2", Price =200, CreatedDate=DateTime.UtcNow,Stock=20 },
			//	new() { Id=Guid.NewGuid(), Name="Product 3", Price =300, CreatedDate=DateTime.UtcNow,Stock=130 },
			//});
			//var count= await _productWriteRepository.SaveAsync();

			
		}
	}
}
