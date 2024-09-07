using FDMiniEcommerceAPI.Application.ViewModels.Products;
using FluentValidation;

namespace FDMiniEcommerceAPI.Application.Validators.Products
{
	public class CreateProductValidator:AbstractValidator<VM_Create_Product>
	{
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MinimumLength(5).MaximumLength(150).WithMessage("Lütfen ürün adını 5 ile 150 karakter arasında giriniz.");

            RuleFor(p => p.Stock).NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                .Must(x => x >= 0).WithMessage("Stok bilgisi negatif olamaz");

			RuleFor(p => p.Price).NotEmpty().NotNull().WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
				.Must(x => x >= 0).WithMessage("Fiyat bilgisi negatif olamaz");

		}
    }
}
